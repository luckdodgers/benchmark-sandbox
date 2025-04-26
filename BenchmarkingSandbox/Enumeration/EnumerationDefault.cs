namespace BenchmarkingSandbox.Enumeration;

using System.Reflection;

public abstract class EnumerationDefault<T> where T : EnumerationDefault<T>
{
    public string Value { get; }
    public static IReadOnlyList<T> AllValues => GetAllValues();

    protected EnumerationDefault()
    {
        // For EF
    }

    protected EnumerationDefault(string value)
    {
        Value = value;
    }

    public static bool TryCreate(string? value, out T? enumeration, StringComparison stringComparison = StringComparison.Ordinal)
    {
        enumeration = null;
        
        var hasValue = HasValue(value, stringComparison);
        if (hasValue)
        {
            enumeration = Create(value!, stringComparison);
        }

        return hasValue;
    }
    
    public static T Create(string value, StringComparison stringComparison = StringComparison.Ordinal)
    {
        var matchingValue = AllValues.FirstOrDefault(x => x.Value.Equals(value, stringComparison));
        if (matchingValue is null)
        {
            throw new ArgumentException($"{value} is not a valid {typeof(T).Name}");
        }

        return matchingValue;
    }
    
    public static bool HasValue(string? value, StringComparison stringComparison = StringComparison.Ordinal) => 
        AllValues.Any(x => x.Value.Equals(value, stringComparison));
    
    public override string ToString() => Value;
    
    public static bool operator == (EnumerationDefault<T> a, EnumerationDefault<T> b)
    {
        if (a is null || b is null)
        {
            return false;
        }

        return a.Value.Equals(b.Value);
    }

    public static bool operator != (EnumerationDefault<T> a, EnumerationDefault<T> b)
    {
        return !(a == b);
    }

    public override int GetHashCode() => Value.GetHashCode();

    public override bool Equals(object obj)
    {
        if (obj is null || obj.GetType() != typeof(T))
        {
            return false;
        }

        return ((T)obj).Value == Value;
    }
    
    private static T[] GetAllValues()
    {
        var properties = typeof(T).GetProperties(
            BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

        return properties.Select(f => f.GetValue(null)).Cast<T>().ToArray();
    }
}