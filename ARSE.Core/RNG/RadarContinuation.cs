using System;
using System.Collections.Generic;
using System.Diagnostics;
using PKHeX.Core;
using ARSE.Core.Interfaces;

namespace ARSE.Core.RNG;

public static class RadarContinuation
{
    private static int GetRoll(ref XorShift128 rng) => rng.NextInt(0, 100);

    private static bool CheckSingle(int chk, int thresh = 93) => chk < thresh;
    private static bool CheckSingle(ref XorShift128 rng, int thresh = 93) => rng.NextInt(0, 100) < thresh;

    public static Task<List<RadarContinuationFrame>> Generate(ulong s0, ulong s1, ulong start, ulong end, RadarContinuationConfig config)
    {
        return Task.Run(() =>
        {
            List<RadarContinuationFrame> results = [];

            var outer = new XorShift128(s0, s1);

            for (ulong z = 0; z < start; z++)
            {
                outer.Next();
            }

            for (ulong i = start; i <= start + end; i++)
            {
                var os = outer.GetState64();
                var rng = new XorShift128(os.s0, os.s1);

                var roll = GetRoll(ref rng);
                var chk = CheckSingle(roll, config.ContinueRate);

                results.Add(new()
                {
                    Advances = $"{i:N0}",
                    Fail = chk ? ' ' : '*',
                    Roll = (byte)roll,

                    Seed0 = $"{os.s0:X16}",
                    Seed1 = $"{os.s1:X16}",
                });

                outer.Next();
            }


            return results;
        });
    }

    public static bool Forecast(ulong s0, ulong s1, decimal min)
    {
        var outer = new XorShift128(s0, s1);
        for (var i = 0; i < min; i++)
        {
            var inner = outer.GetState64();
            var rng = new XorShift128(inner.s0, inner.s1);
            if (!CheckSingle(ref rng))
            {
                if (i >= 80) Debug.Print($"{i}");
                return false;
            }
            outer.Next();
        }
        return true;
    }

    public static (bool found, ulong advances) Forecast(ulong s0, ulong s1, int target, RadarContinuationConfig cfg, ulong init, ulong advances = 0xFFFFFFFF)
    {
        var outer = new XorShift128(s0, s1);

        for (ulong i = 0; i < init; i++) outer.Next();

        for (ulong i = 0; i < advances;)
        {
            var s = outer.GetState64();
            var rng = new XorShift128(s.s0, s.s1);
            ulong chain = 0;
            var loop = true;
            while (loop)
            {
                i++;
                if (CheckSingle(ref rng, cfg.ContinueRate)) chain++;
                else loop = false;

                outer.Next();
            }

            if (chain >= (ulong)target) return (true, --i - chain);
        }

        return (false, 0);
    }

    /*public static void Generate(ulong s0 = 1, ulong s1 = 1)
    {
        var rng = new XorShift128(s0, s1);
        var consecutivefails = 250;
        List<(ulong, ulong)> fails = [];

        while (fails.Count < consecutivefails)
        {
            var (_s0, _s1) = rng.GetState64();
            var chk = CheckSingle(ref rng);
            if (chk)
            {
                fails.Add((_s0, _s1));
            }
            else
            {
                if (fails.Count >= 150)
                {
                    Debug.Print($"{fails.Count} | {fails[0].Item1:X16} {fails[0].Item2:X16}");
                }

                fails.Clear();
            }
        }

        Debug.Print($"{consecutivefails} consecutive successes found!");
        foreach (var (x, y) in fails)
        {
            Debug.Print($"{x:X16} {y:X16}");
        }
    }*/

}

