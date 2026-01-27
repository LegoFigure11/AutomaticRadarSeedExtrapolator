using System.Diagnostics;
using System.Text.Json;
using ARSE.Core.Enums;
using PKHeX.Core;

namespace ARSE.Core;

public static class Encounters
{
    private static readonly Dictionary<string, string[]>? BD;
    private static readonly Dictionary<string, string[]>? SP;
    static Encounters()
    {
        BD = JsonSerializer.Deserialize<Dictionary<string, string[]>>(Utils.GetStringResource("brilliantdiamond.json") ?? "{}");
        SP = JsonSerializer.Deserialize<Dictionary<string, string[]>>(Utils.GetStringResource("shiningpearl.json") ?? "{}");
    }

    public static string[] GetAreaList(Game g) => g switch
    {
        Game.BrilliantDiamond => BD!.Keys.ToArray(),
        _                     => SP!.Keys.ToArray()
    };

    public static string[] GetEncountersForArea(Game g, string a) => g switch
    {
        Game.BrilliantDiamond => BD![a],
        _                     => SP![a]
    };

    public static string[] GetAreasForEncounter(Game g, string s) => g switch
    {
        Game.BrilliantDiamond => GetAreasForSpecies(BD!, s),
        _                     => GetAreasForSpecies(SP!, s),
    };

    public static string[] GetAreasForSpecies(Dictionary<string, string[]> l, string s)
    {
        var o = new HashSet<string>();
        foreach (var (area, encounters) in l)
            if (encounters.Any(e => e == s)) o.Add(area);

        return o.ToArray();
    }

    public static ushort SpeciesNameToValue(string n)
    {
        SpeciesName.TryGetSpecies(n, 2, out var species);
        return species;
    }

    public static string ValueToSpeciesName(ushort s)
    {
        return SpeciesName.GetSpeciesName(s, 2);
    }
}
