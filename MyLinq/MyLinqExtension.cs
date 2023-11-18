namespace MyLinq
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

 
    }
}