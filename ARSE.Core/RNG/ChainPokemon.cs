using ARSE.Core.Interfaces;
using PKHeX.Core;
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

            if (config.UseDelay)
            {
                for (var y = 0; y < config.Delay; y++)
                    outer.Next();
            }

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
                Nature = config.GenerateNature ? Util.GenerateNature(ref rng) : "Sync";
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
                    _adv = i,
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

            var len = config.Cluster;
            if (len == 1) return results;

            List<PokemonFrame> newResults = [];
            for (var i = 0; i < results.Count; i++)
            {
                var thisResult = results[i];
                var testStartIndex = i;
                var testStartValue = thisResult._adv;

                byte cluster = 0;
                for (var j = testStartIndex; j < results.Count; j++)
                {
                    if (results[j]._adv != testStartValue++) break;
                    if (results[j].H != thisResult.H ||
                        results[j].A != thisResult.A ||
                        results[j].B != thisResult.B ||
                        results[j].C != thisResult.C ||
                        results[j].D != thisResult.D ||
                        results[j].S != thisResult.S) break;
                    cluster++;
                }

                if (cluster >= len)
                {
                    thisResult.Advances = $"{thisResult._adv:N0} - {(thisResult._adv + cluster - 1u):N0}";
                    thisResult.Cluster = cluster;
                    newResults.Add(thisResult);
                    thisResult.PID = "Cluster";
                    thisResult.EC = "Cluster";
                    thisResult.Height = "Cluster";
                }

                i += Math.Max(1, cluster - 1);
            }

            return newResults;
        });
    }

    public static Task<List<uint>> GenerateECs(ulong s0, ulong s1, uint ct = 5000)
    {
        return Task.Run(() =>
        {
            List<uint> ECs = [];

            var outer = new XorShift128(s0, s1);

            for (var i = 0u; i < ct; i++)
            {
                var os = outer.GetState64();
                var rng = new XorShift128(os.s0, os.s1);
                ECs.Add(rng.NextUInt());
                outer.Next();
            }

            return ECs;
        });
    }
}

