using System.Collections;
using System.Reflection;


namespace MyCollection
{
    internal class MyList<T> : ICollection<T> where T : IComparable<T>
    {
        List<T> innerList;

        int ICollection<T>.Count => ((ICollection<T>)innerList).Count;

        public bool IsReadOnly => ((ICollection<T>)innerList).IsReadOnly;

        public void Add(T item)
        {
            innerList.Add(item);
            innerList.Sort();
            PrintList(innerList);
        }

        public bool Remove(T item)
        {
            bool isRemove = innerList.Remove(item);
            innerList.Sort();
            PrintList(innerList);
            return isRemove;
        }

        void Clear()
        {
            innerList.Clear();
        }

        bool Contains(T item)
        {
            return innerList.Contains(item);
        }

        void ICollection<T>.Clear()
        {
            ((ICollection<T>)innerList).Clear();
        }

        bool ICollection<T>.Contains(T item)
        {
            return ((ICollection<T>)innerList).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)innerList).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)innerList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)innerList).GetEnumerator();
        }

        private void PrintList(List<T> innerList)
        {
            foreach (Object obj in innerList)
            {
                Type type = obj.GetType();
                foreach (PropertyInfo prop in type.GetProperties())
                {
                    Console.WriteLine($"{prop.Name} = {prop.GetValue(obj, null)}");
                }

                foreach (FieldInfo field in type.GetFields())
                {
                    Console.WriteLine($"{field.Name} = {field.GetValue(obj)}");
                }
            }
            Console.WriteLine("=========================");
        }

        public MyList()
        {
            innerList = new List<T>();
        }
    }
}
