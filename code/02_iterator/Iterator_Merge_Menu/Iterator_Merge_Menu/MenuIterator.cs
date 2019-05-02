using System.Collections;

namespace Iterator_Merge_Menu
{
    public class BreakfastIterator : ITerator
    {
        private readonly ArrayList _items;
        private int _position;

        public BreakfastIterator(ArrayList arrayList)
        {
            _items = arrayList;
        }

        public bool HasNext()
        {
            return _position < _items.Count && _items[_position] != null;
        }

        public object Next()
        {
            return _items[_position++] as MenuItem;
        }
    }

    public class DinnerIterator : ITerator
    {
        private readonly MenuItem[] _items;
        private int _position = 0;

        public DinnerIterator(MenuItem[] items)
        {
            _items = items;
        }
        public bool HasNext()
        {
            return _position < _items.Length && _items[_position] != null;
        }

        public object Next()
        {
            return _items[_position++];
        }
    }
}
