using ARSE.Core.Interfaces;
using PKHeX.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using static ARSE.Core.RNG.Validator;

namespace ARSE.Core.RNG;

public static class ChainPokemon
{
    public static Task<List<PokemonFrame>> Generate(ulong s0, ulong s1, ulong start, ulong end, ChainPokemonConfig config)
    {
        return Task.Run(() =>
        {
            List<PokemonFrame> results = [];

            uint ec;
            uint pid;
            uint fakeID;
            uint ShinyXOR;

            bool PassIVs;
            byte[] IVs;

            uint Ability;
            char Gender;

            string Nature;

            byte Height;

            var outer = new XorShift128(s0, s1);

            for (ulong z = 0; z < start; z++)
                outer.Next();

            for (var i = start; i <= start + end; i++)
            {
                var os = outer.GetState64();
                var rng = new XorShift128(os.s0, os.s1);

                // Encounter Slot, skipped

                // Encryption Constant
                ec = rng.NextUInt();
                if (config.FiltersEnabled && !CheckEC(ec, config.RareEC))
                {
                    outer.Next();
                    continue;
                }

                // PID
                fakeID = rng.NextUInt(); // Used for Shiny checking
                pid = rng.NextUInt();
                pid = Util.GetActualPID(fakeID, pid, config.TID, config.SID, config.Shiny);
                ShinyXOR = Util.GetShinyXOR(pid, config.TSV);
                if (!CheckIsShiny(ShinyXOR, config.TargetShiny))
                {
                    outer.Next();
                    continue;
                }


                // IVs
                (PassIVs, IVs) = Util.GenerateIVs(ref rng, config);
                if (!PassIVs) // FiltersEnabled check takes place in GenerateIVs
                {
                    outer.Next();
                    continue;
                }

                // Ability
                Ability = config.ForceHiddenAbility ? 4 : 1 + rng.NextUInt(2);

                // Gender
                Gender = config.RollGender ? ((rng.NextUInt(253) + 1) < config.GenderRatio ? 'F' : 'M') : config.Gender;

                // Nature
                Nature = Util.GenerateNature(ref rng, config.IsSync);
                if (config.FiltersEnabled && !CheckNature(Nature, config.TargetNature))
                {
                    outer.Next();
                    continue;
                }

                // Height
                Height = (byte)(rng.NextUInt(0x81) + rng.NextUInt(0x80));
                if (config.FiltersEnabled && !CheckHeight(Height, config.TargetScale))
                {
                    outer.Next();
                    continue;
                }

                // Weight, skipped
                // Item, skipped

                results.Add(new PokemonFrame
                {
                    Advances = $"{i:N0}",

                    PID = $"{pid:X8}",
                    EC = $"{ec:X8}",

                    H = IVs[0],
                    A = IVs[1],
                    B = IVs[2],
                    C = IVs[3],
                    D = IVs[4],
                    S = IVs[5],

                    Shiny = Util.GetShinyType(ShinyXOR),

                    Ability = Ability switch
                    {
                        1 => '1',
                        2 => '2',
                        _ => 'H'
                    },

                    Gender = Gender,
                    Nature = Nature,

                    Height = Util.GetHeightString(Height),

                    Seed0 = $"{os.s0:X16}",
                    Seed1 = $"{os.s1:X16}",
                });

                outer.Next();
            }


            return results;
        });
    }
}

