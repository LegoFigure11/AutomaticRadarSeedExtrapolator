using PKHeX.Core;

namespace ARSE.Core.RNG;

public static class Outbreak
{
    public static Task<uint> Generate(ulong seed, uint target)
    {
        return Task.Run(() =>
        {
            uint lower = (uint)(seed & 0xFFFFFFFF);
            var outer = lower;

            for (uint i = 0; i < 50000; i++)
            {
                var daily = GetDaily(outer);
                if (daily % 28 == target) return i;
                outer = ARNG.Next(outer);
            }

            return 0u;
        });
    }

    private static uint GetDaily(uint seed)
    {
        return (uint)((seed & 0x80000000) != 0 ? 0x100000000 - seed : seed);
    }
}

