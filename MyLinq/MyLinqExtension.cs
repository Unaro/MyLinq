﻿namespace MyLinq
{
    public static class MyLinqExtension
    {
        public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> values, Predicate<TSource> predicate)
        {
            if (values == null) throw new InvalidOperationException(nameof(values));
            List<TSource> res = new();

            foreach (TSource value in values)
            {
                if (predicate.Invoke(value)) res.Add(value);
            }

            return res.ToArray();

        } 
        public static TSource First<TSource>(this IEnumerable<TSource> sources)
        {
            foreach (TSource value in sources)
                return value;
            throw new InvalidOperationException(nameof(sources));
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> sources)
        {
            foreach (TSource value in sources)
                return value;
           return default;
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> sources, Predicate<TSource> predicate)
        {
            foreach (TSource value in sources)
                if(predicate?.Invoke(value) is true)
                {
                    return value;
                }
                
            return default;
        }

        public static bool Any<TSource>(this IEnumerable<TSource> sources, Predicate<TSource> predicate)
        {
            foreach (TSource value in sources)
                if (predicate?.Invoke(value) is true)
                {
                    return true;
                }

            return false;
        }

        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> sources, Func<TSource, TResult> func)
        {
            List<TResult> list = new();
            foreach(TSource value in sources)
                list.Add(func.Invoke(value));

            return list;

        }
    }
}