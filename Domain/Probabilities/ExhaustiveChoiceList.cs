using System.Collections;

namespace Domain.Probabilities;

public partial class ExhaustiveChoiceList<T>
{
    private List<int> _availableIndices = [];

    public T Choose()
    {
        if (_choices.Count == 0) throw new InvalidOperationException("No choices available.");
        if (_availableIndices.Count == 0) ResetAvailableIndices();

        int index = Random.Shared.Next(_availableIndices.Count);
        T choice = _choices[_availableIndices[index]];
        _availableIndices.RemoveAt(index);
        return choice;
    }

    private void ResetAvailableIndices()
        => _availableIndices = Enumerable.Range(0, _choices.Count).ToList();
}

// LIST IMPLEMENTATION BOILERPLATE
public partial class ExhaustiveChoiceList<T> : IList<T>, IReadOnlyList<T>
{
    private readonly List<T> _choices = [];

    public T this[int index] { get => ((IList<T>)_choices)[index]; set => ((IList<T>)_choices)[index] = value; }

    public int Count => ((ICollection<T>)_choices).Count;

    public bool IsReadOnly => ((ICollection<T>)_choices).IsReadOnly;

    public bool IsFixedSize => ((IList)_choices).IsFixedSize;

    public bool IsSynchronized => ((ICollection)_choices).IsSynchronized;

    public object SyncRoot => ((ICollection)_choices).SyncRoot;

    public void Add(T item)
    {
        ((ICollection<T>)_choices).Add(item);
        ResetAvailableIndices();
    }
    
    public void Clear()
    {
        ((ICollection<T>)_choices).Clear();
        ResetAvailableIndices();
    }

    public bool Contains(T item)
    {
        return ((ICollection<T>)_choices).Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        ((ICollection<T>)_choices).CopyTo(array, arrayIndex);
    }

    public void CopyTo(Array array, int index)
    {
        ((ICollection)_choices).CopyTo(array, index);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)_choices).GetEnumerator();
    }

    public int IndexOf(T item)
    {
        return ((IList<T>)_choices).IndexOf(item);
    }

    public void Insert(int index, T item)
    {
        ((IList<T>)_choices).Insert(index, item);
        ResetAvailableIndices();
    }

    public bool Remove(T item)
    {
        bool removed = ((ICollection<T>)_choices).Remove(item);
        ResetAvailableIndices();
        return removed;
    }

    public void RemoveAt(int index)
    {
        ((IList<T>)_choices).RemoveAt(index);
        ResetAvailableIndices();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_choices).GetEnumerator();
    }
}