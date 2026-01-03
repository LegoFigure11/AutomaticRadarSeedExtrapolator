namespace ARSE.Core.Structures;

public abstract class Offsets
{
    public const string ShiningPearlID                              = "010018E011D92000";
    public const string BrilliantDiamondID                          = "0100000011D90000";

    public static IReadOnlyList<long> MainRNGPointer       { get; } = [0x4FD43D0, 0x0];
    public const int MainRNG_SIZE                                   =  0x10;

    public static IReadOnlyList<long> MyStatusTIDPointerBD { get; } = [0x4C64DC0, 0xB8, 0x10, 0xE8];
    public static IReadOnlyList<long> MyStatusTIDPointerSP { get; } = [0x4E7BE98, 0xB8, 0x10, 0xE8];
}
