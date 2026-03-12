using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

// README.md를 읽고 코드를 작성하세요.


Stack stack = new Stack();
stack.Push(200);
stack.Push(100);

int value2 = (int)stack.Pop();
int value1 = (int)stack.Pop();

Console.WriteLine($"값1: {value1}, 값2: {value2}");


Stack<int> stackG = new Stack<int>();
stackG.Push(value1);
stackG.Push(value2);

value2 = stackG.Pop();
value1 = stackG.Pop();

Console.WriteLine($"값1: {value1}, 값2: {value2}");



Cup<string> cup = new Cup<string>();
Cup<int> cup1 = new Cup<int>();

cup.Value = "커피";
cup1.Value = 500;

Console.WriteLine($"음료: {cup.Value}");
Console.WriteLine($"용량: {cup1.Value}ml");


Pair<string, int> pair1 = new Pair<string,int>("용사", 100);
Pair<int, double> pair2 = new Pair<int,double>(1, 95.5);

Console.WriteLine($"이름: {pair1.First}, HP: {pair1.Second}");
Console.WriteLine($"순위: {pair2.First}등, 점수: {pair2.Second}점");


int a = 10;
int b = 20;

Console.WriteLine($"교환 전: a = {a}, b = {b}");
Swap<int>(ref a, ref b);
Console.WriteLine($"교환 후: a = {a}, b = {b}");

string str1 = "사과";
string str2 = "바나나";

Console.WriteLine($"교환 전: str1 = {a}, str2 = {b}");
Swap<string>(ref str1, ref str2);
Console.WriteLine($"교환 후: str1 = {a}, str2 = {b}");


void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}


NumberContainer<int> num1 = new NumberContainer<int>();
num1.Value = 100;

NumberContainer<float> num2 = new NumberContainer<float>();
num2.Value = 3.14f;

Console.WriteLine($"정수값: {num1.Value}");
Console.WriteLine($"실수값: {num2.Value}");


Monster m  = CreateInstance<Monster>();
m.Name = "슬라임";
m.Health = 50;

Console.WriteLine($"생성된 몬스터: {m.Name}, HP: {m.Health}");




Console.WriteLine($"더 큰 정수: {GetMax<int>(10, 25)}");
Console.WriteLine($"사전순 뒤: {GetMax<string>("apple", "banana")}");


Console.WriteLine($"int 기본값: {GetDefaultValue<int>()}");
Console.WriteLine($"bool 기본값: {GetDefaultValue<bool>()}");
Console.WriteLine($"string 기본값: {GetDefaultValue<string>() ?? "(null)"}");


List<string> names = new List<string>();

names.Add("철수");
names.Add("영희");
names.Add("민수");

Dictionary<string, int> pairs = new Dictionary<string, int>();

pairs["철수"] = 95;
pairs["영희"] = 88;
pairs["민수"] = 92;

Console.WriteLine("이름 목록:");
foreach (var name in names)
{
    Console.WriteLine($"- {name}");
}

Console.WriteLine("점수:");

foreach (var pair in pairs)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}점");

}




T GetDefaultValue<T>()
{
    return default(T);
}


T GetMax<T>(T a, T b) where T: IComparable<T>
{
    T result = a.CompareTo(b) > 0 ? a : b;

    return result;
}

T CreateInstance<T>() where T : new()
{
 
    return new T();
}

SpecialContainer<string> special = new SpecialContainer<string>();
special.Value = "특별한 아이템";
special.Description = "레어 등급";

Console.WriteLine($"{special.Value} ({special.Description})");

IntContainer container = new IntContainer();
container.Value = 50;

Console.WriteLine($"값: {container.Value}, 두 배: {container.Double()}");


Counter<int> c = new Counter<int>();
Counter<string> d = new Counter<string>();

Counter<int>.Count = 2;
Counter<string>.Count = 1;

Console.WriteLine($"Counter<int>.Count: {Counter<int>.Count}");
Console.WriteLine($"Counter<string>.Count: {Counter<string>.Count}");
class Counter<T>
{
    public static int Count;
}


class Container<T>
{
    public T Value { get; set; }
}

class SpecialContainer<T>: Container<T>
{
    public string Description;
}

class IntContainer : Container<int>
{
    public int Double() => Value * 2; 
}


class Monster
{
    public string Name { get; set; }
    public int Health { get; set; }


}


class NumberContainer<T> where T: struct
{
    public T Value { get; set; }
}




class Pair<TFirst, TSecond>
{
    public TFirst First { get; set; }
    public TSecond Second { get; set; }

    public Pair(TFirst first, TSecond second)
    {
        First = first;
        Second = second;
    }
}

class Cup<T>
{
    public T Value { get; set; }
}