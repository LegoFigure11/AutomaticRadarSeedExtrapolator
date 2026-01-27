namespace ARSE.Core.Structures;

// See also: https://github.com/architdate/PKHeX-Plugins/blob/c8e23a43dc48147a8099ee30ad8481c5af839ebb/PKHeX.Core.Injection/LiveHeXBlockClasses/SwayGrass.cs#L6
public class SwayGrass(byte[] data)
{
    public const byte SIZE = 0xC0;

    public readonly byte[] Data = data;

    //public bool IsSwayGrassFlag  => Data[0x00] != 0;
    // public uint SwayZone => BitConverter.ToUInt32(Data, 0x04);

    public byte ChainCount => Data[0x20];

    public uint ChainEncounterSpecies => BitConverter.ToUInt32(Data, 0x24);
}
