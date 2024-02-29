namespace Domain.Probabilities;

public readonly record struct Probability : IComparable<Probability>
{
    private readonly double _value;

    public Probability(double value)
    {
        if (value is < 0 or > 1) throw new ArgumentException($"A probability must be between 0 and 1. The given value {value} is outside of that range.", nameof(value));
        _value = value;
    }

    public int CompareTo(Probability other)
        => _value.CompareTo(other._value);

    public static implicit operator double(Probability p) => p._value;
    public static implicit operator Probability(double d) => new(d);
}