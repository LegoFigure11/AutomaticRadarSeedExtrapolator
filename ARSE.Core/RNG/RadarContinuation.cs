using PKHeX.Core;
using ARSE.Core.Interfaces;

namespace ARSE.Core.RNG;

public static class RadarContinuation
{
    private static int GetRoll(ref XorShift128 rng) => rng.NextInt(0, 100);

    private static bool CheckSingle(int chk, int thresh = 93) => chk < thresh;
    private static bool CheckSingle(ref XorShift128 rng, int thresh = 93) => GetRoll(ref rng) < thresh;

    public static Task<List<RadarContinuationFrame>> Generate(ulong s0, ulong s1, ulong start, ulong end, RadarContinuationConfig config)
    {
        return Task.Run(() =>
        {
            List<RadarContinuationFrame> results = [];

            var outer = new XorShift128(s0, s1);

            for (ulong z = 0; z < start; z++)
                outer.Next();

            for (var i = start; i <= start + end; i++)
            {
                var os = outer.GetState64();
                var rng = new XorShift128(os.s0, os.s1);

                var roll = GetRoll(ref rng);
                var chk = CheckSingle(roll, config.ContinueRate);

                results.Add(new RadarContinuationFrame
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

    public static (bool found, ulong advances) Forecast(ulong s0, ulong s1, uint target, RadarContinuationConfig cfg, ulong init, ulong advances = 0xFFFFFFFF)
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

            if (chain >= target) return (true, --i - chain);
        }

        return (false, 0);
    }

    public static List<(bool found, ulong advances)> ForecastMany(ulong s0, ulong s1, uint target, RadarContinuationConfig cfg, ulong init, ulong advances = 0xFFFFFFFF, int num = 4)
    {
        List<(bool, ulong)> res = [];
        var outer = new XorShift128(s0, s1);

        for (ulong i = 0; i < init; i++) outer.Next();

        for (ulong i = 0; i < advances && res.Count < num;)
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

            if (chain >= target) res.Add((true, i - chain - 1));
        }

        for (var i = res.Count; i < num; i++)
        {
            res.Add((false, 0));
        }

        return res;

    }
}

