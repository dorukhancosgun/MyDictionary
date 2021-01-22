using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] _keys;
        T2[] _values;

        public MyDictionary()
        {

            _keys = new T1[0];
            _values = new T2[00];

        }

        public void Add(T1 item1, T2 item2)
        {

            T1[] tempArray = _keys;
            T2[] tempArray2 = _values;

            _keys = new T1[_keys.Length + 1];
            _values = new T2[_values.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                _keys[i] = tempArray[i];
            }

            _keys[_keys.Length - 1] = item1;

            for (int j = 0; j < tempArray2.Length; j++)
            {
                _values[j] = tempArray2[j];

            }
            _values[_values.Length - 1] = item2;
        }

        public int Count
        {
            get { return _keys.Length; }
        }

        public T1 Keys
        {
            get { return _keys[_keys.Length - 1]; }
        }
        public T2 Values
        {
            get { return _values[_values.Length - 1]; }
        }




    }
}
