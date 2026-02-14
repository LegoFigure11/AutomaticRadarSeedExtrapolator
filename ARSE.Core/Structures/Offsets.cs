namespace ARSE.Core.Structures;

public abstract class Offsets
{
    public const string ShiningPearlID                              = "010018E011D92000";
    public const string BrilliantDiamondID                          = "0100000011D90000";

    public static IReadOnlyList<long> MainRNGPointer       { get; } = [0x4FD43D0, 0x0];
    public const int MainRNG_SIZE                                   =  0x10;

    public static IReadOnlyList<long> MyStatusTIDPointerBD { get; } = [0x4C64DC0, 0xB8, 0x10, 0xE8];
    public static IReadOnlyList<long> MyStatusTIDPointerSP { get; } = [0x4E7BE98, 0xB8, 0x10, 0xE8];

    public static IReadOnlyList<long> SwayGrassPoinerBD { get; } = [0x4C5AC58, 0xB8, 0x0];
    public static IReadOnlyList<long> SwayGrassPoinerSP { get; } = [0x4E71D30, 0xB8, 0x0];

    public static IReadOnlyList<long> WildPokemonPointerBD { get; } = [0x4C59EF0, 0x20, 0x98, 0x0, 0x20];
    public static IReadOnlyList<long> WildPokemonPointerSP { get; } = [0x4E70FC8, 0x20, 0x98, 0x0, 0x20];

    public static IReadOnlyList<long> RadarStepCounterPointerBD { get; } = [0x476BF50, 0xB8, 0x0, 0x2AE];
    public static IReadOnlyList<long> RadarStepCounterPointerSP { get; } = [0x4983028, 0xB8, 0x0, 0x2AE];
}
