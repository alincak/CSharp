using System;

namespace OperatorOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      var m1 = new MyClass(10);
      var m2 = new MyClass(15);

      var result = MyClass.Add(m1, m2);
      Console.WriteLine("MyClass.Add : " + result.Val);

      Console.WriteLine();

      var result2 = m1 + m2;
      Console.WriteLine("operator + : " + result2.Val);

      if (m1 >= m2)
      {
        //...
      }

      if (m1 == 10)
      {
        //...
      }

      m1++;
    }
  }

  class MyClass
  { 
    public double Val { get; private set; }

    public MyClass(double _val)
    {
      Val = _val;
    }

    public static MyClass Add(MyClass m1, MyClass m2)
    {
      var result = m1.Val + m2.Val;

      return new MyClass(result);
    }

    public static MyClass operator +(MyClass m1, MyClass m2)
    {
      var result = m1.Val + m2.Val;

      return new MyClass(result);
    }

    //!=,==,>=,<=
    public static bool operator !=(MyClass m1, double val) //!=,MyClass,double
    {
      return m1.Val != val;
    }

    public static bool operator ==(MyClass m1, double val) //==,MyClass,MyClass
    {
      return m1.Val == val;
    }

    public static bool operator >=(MyClass m1, MyClass m2)
    {
      return m1.Val >= m2.Val;
    }

    public static bool operator <=(MyClass m1, MyClass m2)
    {
      return m1.Val >= m2.Val;
    }

    //-,+,--,++
    public static MyClass operator ++(MyClass m1)
    {
      return new MyClass(m1.Val + 1);
    }
  }
}