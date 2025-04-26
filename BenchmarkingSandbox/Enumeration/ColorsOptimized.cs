namespace BenchmarkingSandbox.Enumeration;

public class ColorsOptimized : EnumerationOptimized<ColorsOptimized>
{
    public static ColorsOptimized AbsoluteZero => new(nameof(AbsoluteZero));
    public static ColorsOptimized AcidGreen => new(nameof(AcidGreen));
    public static ColorsOptimized AfricanViolet => new(nameof(AfricanViolet));
    public static ColorsOptimized Alizarin => new(nameof(Alizarin));
    public static ColorsOptimized AlloyOrange => new(nameof(AlloyOrange));
    public static ColorsOptimized Almond => new(nameof(Almond));
    public static ColorsOptimized Amethyst => new(nameof(Amethyst));
    public static ColorsOptimized Aquamarine => new(nameof(Aquamarine));
    public static ColorsOptimized Aureolin => new(nameof(Aureolin));
    public static ColorsOptimized BananaMania => new(nameof(BananaMania));
    public static ColorsOptimized BattleshipGrey => new(nameof(BattleshipGrey));
    public static ColorsOptimized BlizzardBlue => new(nameof(BlizzardBlue));
    public static ColorsOptimized BlueSapphire => new(nameof(BlueSapphire));
    public static ColorsOptimized Bluetiful => new(nameof(Bluetiful));
    public static ColorsOptimized Burlywood => new(nameof(Burlywood));
    public static ColorsOptimized CaribbeanGreen => new(nameof(CaribbeanGreen));
    
    private ColorsOptimized()
    {
    }
    
    protected ColorsOptimized(string value) : base(value)
    {
    }
}