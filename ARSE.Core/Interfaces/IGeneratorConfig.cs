using ARSE.Core.Enums;
using PKHeX.Core;

namespace ARSE.Core.Interfaces;

internal interface IGeneratorConfig;

public class RadarContinuationConfig : IGeneratorConfig
{
    public int ContinueRate { get; set; } = 93;
}

public class ChainPokemonConfig : IGeneratorConfig
{
    private const byte Male = 0x00;
    private const byte Female = 0xFE;
    private const byte Genderless = 0xFF;

    public byte Cluster { get; set; } = 0;
    public ushort Species { get; set; } = 0;
    public byte GenderRatio => EntityGender.GetGenderRatio(Species);
    public bool RollGender => GenderRatio is not (Male or Female or Genderless);
    public char Gender => GenderRatio switch
    {
        Male       => 'M',
        Female     => 'F',
        Genderless => '-',
        _          => ' ',
    };

    public int ChainLength { get; set; } = 0;
    public int GuaranteedIVs => ChainLength switch
    {
        99 => 5,
        39 => 3,
        29 => 2,
        19 => 1,
        _  => 0,
    };

    public bool IsSync { get; set; } = false;
    public bool GenerateNature => !IsSync; // Sync causes Nature generation to be skipped, matters for H/W
    public Nature TargetNature { get; set; } = Nature.Random;
    public bool IsShinyPatch { get; set; } = false;
    public Shiny Shiny => IsShinyPatch ? Shiny.Always : Shiny.Random;

    public ShinyType TargetShiny { get; set; } = ShinyType.Any;
    public ScaleType TargetScale { get; set; } = ScaleType.Any;

    public bool ForceHiddenAbility { get; set; } = false;

    public uint[] TargetMinIVs { get; set; } = [0, 0, 0, 0, 0, 0];
    public uint[] TargetMaxIVs { get; set; } = [31, 31, 31, 31, 31, 31];
    public IVSearchType[] SearchTypes { get; set; } = [IVSearchType.Range, IVSearchType.Range, IVSearchType.Range, IVSearchType.Range, IVSearchType.Range, IVSearchType.Range];

    public bool RareEC { get; set; } = false;

    public bool UseDelay { get; set; } = false;
    public uint Delay { get; set; } = 0;

    public uint TID { get; set; } = 0;
    public uint SID { get; set; } = 0;
    public uint TSV => RNG.Util.GetShinyValue(TID, SID);

    public bool FiltersEnabled { get; set; } = false;
}
