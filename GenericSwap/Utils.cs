using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


static class Utils
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;

    }


    public static void SwapInArray<T>(T[] array, int index1, int index2)
    {
        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }


    public static T FindMin<T>(T[] array) where T : IComparable<T>
    {
        T min = array[0];
        foreach (T t in array)
            min = t.CompareTo(min) < 0 ? t : min;

        return min;

    }
    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        T max = array[0];
        foreach (T t in array)
            max = t.CompareTo(max) > 0 ? t : max;

        return max;

    }

    public static void Reverse<T>(T[] array) 
    {
        Array.Reverse(array);
    }
}