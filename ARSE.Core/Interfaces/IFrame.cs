namespace ARSE.Core.Interfaces;

internal interface IBasicFrame
{
    string Advances { get; }
    string Seed0    { get; }
    string Seed1    { get; }
}

internal interface IRadarContinuationFrame
{
    char Fail  { get; }
    byte Roll  { get; }
}

public class RadarContinuationFrame : IBasicFrame, IRadarContinuationFrame
{
    public string Advances { get; set; } = string.Empty;

    public string Seed0    { get; set; } = string.Empty;
    public string Seed1    { get; set; } = string.Empty;

    public char Fail       { get; set; } = ' ';
    public byte Roll       { get; set; } = 0;
}

public class PokemonFrame : IBasicFrame
{
    public string Advances { get; set; } = string.Empty;
    public string Species { get; set; } = string.Empty;
    public string Shiny { get; set; } = string.Empty;

    public char Ability { get; set; } = ' ';
    public string Nature { get; set; } = string.Empty;
    public char Gender { get; set; } = ' ';

    public byte H { get; set; } = 0;
    public byte A { get; set; } = 0;
    public byte B { get; set; } = 0;
    public byte C { get; set; } = 0;
    public byte D { get; set; } = 0;
    public byte S { get; set; } = 0;

    public string EC { get; set; } = string.Empty;
    public string PID { get; set; } = string.Empty;
    public string Height { get; set; } = string.Empty;

    public string Seed0 { get; set; } = string.Empty;
    public string Seed1 { get; set; } = string.Empty;
}

