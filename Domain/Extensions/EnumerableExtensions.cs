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
}