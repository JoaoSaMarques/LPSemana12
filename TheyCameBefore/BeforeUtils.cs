using System;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, 
        T item)
            where T : IComparable<T>
        {
            foreach (T currentItem in items)
            {
                if (currentItem.CompareTo(item) < 0)
                {
                    yield return currentItem;
                }             
            }

        }
    }
}
