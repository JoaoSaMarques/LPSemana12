using System;

namespace MyGenericClass
{
    public class Guarda3<T>
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
    }
}
