using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemoo
{
    class MyDictionary<T_Key, T_Value>
    {
        T_Key[] keys;
        T_Value[] values;
        public MyDictionary()
        {
            keys = new T_Key[0];
            values = new T_Value[0];

        }
        public void Add(T_Key key, T_Value value)
        {
            T_Key[] tempKey = keys;
            T_Value[] tempValue = values;
            keys = new T_Key[keys.Length + 1];
            values = new T_Value[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            for (int j = 0; j < tempKey.Length; j++)
            {
                if (key == null)
                {
                    throw new ArgumentNullException("key can't be null");
                }
                else if (tempKey[j].Equals(key))
                {
                    throw new ArgumentException("this key already exist.");
                }


            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public void ListAll()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key:" + keys[i] + " Value:" + values[i]);
            }
        }

    }
}
