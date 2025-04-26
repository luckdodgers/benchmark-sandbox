namespace BenchmarkingSandbox.Enumeration;

public class ColorsDefault : EnumerationDefault<ColorsDefault>
{
    public static ColorsDefault AbsoluteZero => new(nameof(AbsoluteZero));
    public static ColorsDefault AcidGreen => new(nameof(AcidGreen));
    public static ColorsDefault AfricanViolet => new(nameof(AfricanViolet));
    public static ColorsDefault Alizarin => new(nameof(Alizarin));
    public static ColorsDefault AlloyOrange => new(nameof(AlloyOrange));
    public static ColorsDefault Almond => new(nameof(Almond));
    public static ColorsDefault Amethyst => new(nameof(Amethyst));
    public static ColorsDefault Aquamarine => new(nameof(Aquamarine));
    public static ColorsDefault Aureolin => new(nameof(Aureolin));
    public static ColorsDefault BananaMania => new(nameof(BananaMania));
    public static ColorsDefault BattleshipGrey => new(nameof(BattleshipGrey));
    public static ColorsDefault BlizzardBlue => new(nameof(BlizzardBlue));
    public static ColorsDefault BlueSapphire => new(nameof(BlueSapphire));
    public static ColorsDefault Bluetiful => new(nameof(Bluetiful));
    public static ColorsDefault Burlywood => new(nameof(Burlywood));
    public static ColorsDefault CaribbeanGreen => new(nameof(CaribbeanGreen));
    
    private ColorsDefault()
    {
    }
    
    protected ColorsDefault(string value) : base(value)
    {
    }
}