using Domain.Extensions;

namespace Domain.Probabilities;

public class EscalatingProbability
{
    private Probability _currentProbability;
    private readonly IEnumerable<Probability> _escalatingOdds;
    private IEnumerator<Probability> _escalatingOddsEnumerator;

    public EscalatingProbability(IEnumerable<Probability> escalatingOdds)
    {
        _escalatingOdds = escalatingOdds.CloneEnumerable();
        _escalatingOddsEnumerator = _escalatingOdds.GetEnumerator();
        if (_escalatingOddsEnumerator.MoveNext())
        {
            _currentProbability = _escalatingOddsEnumerator.Current;
        }
    }

    public Probability GetCurrentProbability()
        => _currentProbability;

    public void Escalate()
    {
        if (_escalatingOddsEnumerator.MoveNext())
        {
            _currentProbability = _escalatingOddsEnumerator.Current;
        }
    }

    public void Reset()
    {
        _escalatingOddsEnumerator.Dispose();
        _escalatingOddsEnumerator = _escalatingOdds.GetEnumerator();
    }
}