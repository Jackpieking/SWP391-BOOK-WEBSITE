using System;
using System.Collections.Generic;

namespace Helper;

public static class ExtensionMethod
{
    public static void ForEach<T>(
        this IEnumerable<T> collections,
        Action<T> action)
            where T : class
    {
        foreach (var item in collections)
        {
            action(obj: item);
        }
    }
}
