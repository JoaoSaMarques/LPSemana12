using System.Collections;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T[] items;

        /// <summary>
        /// Constructorish
        /// </summary>
        public Guarda3()
        {
            items = new T[3];
        }

        /// <summary>
        /// Get items
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T GetItem(int i)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();

            return items[i];
        }

        /// <summary>
        /// Set items
        /// </summary>
        /// <param name="i"></param>
        /// <param name="item"></param>
        public void SetItem(int i, T item)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();

            items[i] = item;
        }

        /// <summary>
        /// Add item
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            for (int i = 0; i < 3; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], default(T)))
                {
                    items[i] = item;
                    return;
                }
            }
        }

        /// <summary>
        /// Get enumerator public
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        //Return Enumerator
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
