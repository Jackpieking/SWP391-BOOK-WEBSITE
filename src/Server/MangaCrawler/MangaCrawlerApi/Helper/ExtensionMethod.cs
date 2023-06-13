using System;
using System.Collections.Generic;

namespace MangaCrawlerApi.Helper;

public static class ExtensionMethod
{
    public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action) where T : class
    {
        foreach (var item in collection)
        {
            action(obj: item);
        }
    }
}
