namespace MyLinq
{
    public static class MyLinqExtension
    {
        public static TSource[] Where<TSource>(this TSource[] values, Predicate<TSource> predicate)
        {
            if (values == null) throw new InvalidOperationException(nameof(values));
            List<TSource> res = new();

            foreach (TSource value in values)
            {
                if (predicate.Invoke(value)) res.Add(value);
            }

            return res.ToArray();

        } 
    }
}