using System;
using System.Collections.Generic;
using System.Text;


class MyStack<T>
{
    public T[] values;
    public int count;
    public int Count {  get { return count; } }

    public bool IsEmpty {  get { return Count == 0; } }
    public MyStack(int capacity)
    {
        values = new T[capacity];
    }


    public void Push(T item)
    {
        values[count++] = item;
    }

    public T Pop()
    {
        T item = values[count-1];
        values[count-1] = default(T);
        
        count -= 1;


        return item;
    }

    public T Peek()
    {
        return values[count-1]; 
    }


}