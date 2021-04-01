using System.Collections;
using System.Collections.Generic;

namespace SharpTest
{
    public class Cycler<T>
    {
        private IEnumerator _items;

        public Cycler(IEnumerable items)
        {
            _items = items.GetEnumerator();
        }

        public T GetNext()
        {
            if (!_items.MoveNext())
            {
                _items.Reset();
                _items.MoveNext();
            }

            return (T)_items.Current;
        }
    }
}