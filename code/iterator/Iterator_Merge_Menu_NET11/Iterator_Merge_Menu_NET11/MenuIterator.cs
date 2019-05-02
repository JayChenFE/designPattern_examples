using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Merge_Menu_NET11
{
    public class BreakfastIterator : IEnumerator
    {
        private readonly ArrayList _items;
        private int _position = -1;

        public BreakfastIterator(ArrayList arrayList)
        {
            _items = arrayList;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _items.Count;
        }

        public object Current => _items[_position];

        public void Reset()
        {
            _position = -1;
        }
    }

    public class DinnerIterator : IEnumerator
    {
        private readonly MenuItem[] _items;
        private int _position = -1;

        public DinnerIterator(MenuItem[] items)
        {
            this._items = items;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _items.Length && _items[_position] != null;
        }

        public object Current => _items[_position];

        public void Reset()
        {
            _position = -1;
        }

    }
}
