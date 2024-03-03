namespace Domain.Extensions;

public static class EnumerableExtensions
{
    public static IEnumerable<T> CloneEnumerable<T>(this IEnumerable<T> source)
    {
        foreach (T item in source)
        {
            yield return item;
        }
    }

    public static decimal CountDecimal<T>(this IEnumerable<T> source)
    {
        decimal count = 0;
        foreach (var item in source)
        {
            count++;
        }
        return count;
    }

    public static decimal CountDecimal<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        decimal count = 0;
        foreach (var item in source)
        {
            if (predicate(item))
            {
                count++;
            }
        }
        return count;
    }
}