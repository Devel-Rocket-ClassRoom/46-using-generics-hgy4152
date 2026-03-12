using System;
using System.Collections.Generic;
using System.Text;

class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    public Dictionary<TKey,TValue> diction = new Dictionary<TKey, TValue>();

    public int Count {  get { return diction.Count; } }

    public int _count = 0;
    public TKey[] keys; 
    public TValue[] values;


    public Registry(int  capacity)
    {
        keys = new TKey[capacity];
        values = new TValue[capacity];
    }


    public void Register(TKey key, TValue value)
    {
        diction[key] = value;
        keys[_count++] = key;

    }

    public TValue Find(TKey key)
    {
        return diction.ContainsKey(key) ? diction[key] : default(TValue) ;
    }

    public bool Contains(TKey key)
    {
        return diction.ContainsKey(key); 
    }


    public void PrintAll()
    {
        for (int i = 0; i < diction.Count; i++)
            Console.WriteLine($"[{keys[i]}] {diction[keys[i]]}");
    }
}