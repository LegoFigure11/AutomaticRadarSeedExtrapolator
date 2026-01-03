using PKHeX.Core;

namespace ARSE.Core.RNG;

public static class Util
{
    public const uint MAX_TRACKED_ADVANCES = 50_000; // 50,000 chosen arbitrarily to prevent an infinite loop

    public static uint GetAdvancesPassed(ulong s0, ulong s1, ulong _s0, ulong _s1, ulong limit = MAX_TRACKED_ADVANCES)
    {
        if (s0 == _s0 && s1 == _s1) return 0;
        var rng = new XorShift128(s0, s1);
        uint i = 0;
        do
        {
            i++;
            rng.Next();

            var (cur0, cur1) = rng.GetState64();
            if (cur0 == _s0 && cur1 == _s1) break;

        } while (i < limit);

        return i;
    }

    public static int GetRateFromComboBox(int selected) => selected switch
    {
        0 => 53,
        1 => 63,
        2 => 73,
        3 => 83,
        _ => 93,
    };

    public static string GetTurboCommandFromComboBox(int selected) => selected switch
    {
        1 => "A",
        2 => "HOME",
        _ => string.Empty,
    };
}
