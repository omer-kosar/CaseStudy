using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.GenericCollection
{
    internal class CustomGenericCollection<T> : IList<T>
    {
        private List<T> _myList = new List<T>();
        public T this[int index]
        {
            get => _myList[index];
            set => _myList[index] = value;
        }

        public int Count => _myList.Count;

        public bool IsReadOnly => false;

        public void Add(T item) => _myList.Add(item);

        public void Clear() => _myList.Clear();

        public bool Contains(T item) => _myList.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => _myList.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator() => _myList.GetEnumerator();

        public int IndexOf(T item) => _myList.IndexOf(item);

        public void Insert(int index, T item) => _myList.Insert(index, item);

        public bool Remove(T item) => _myList.Remove(item);

        public void RemoveAt(int index) => _myList.RemoveAt(index);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
