namespace ARSE.Core.Interfaces;

internal interface IGeneratorConfig
{
    
}

public class RadarContinuationConfig : IGeneratorConfig
{
    public int ContinueRate { get; set; } = 93;
}
