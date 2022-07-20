using System;
namespace Models;

public static class Extensions
{

    public static IEnumerable<List<T>> partition<T>(this List<T> values, int chunkSize)
    {
        for (int i = 0; i < values.Count; i += chunkSize)
        {
            yield return values.GetRange(i, Math.Min(chunkSize, values.Count - i));
        }
    }



}

