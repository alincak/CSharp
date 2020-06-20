using System;

namespace Delegate
{
  class Program
  {
    public delegate void Del(string message);

    static void Main(string[] args)
    {
      Del handler = DelegateMethod;
      handler("DelegateMethod");
      Console.WriteLine();

      var obj = new MethodClass();
      Del d1 = obj.Method1;
      Del d2 = obj.Method2;
      Del d3 = DelegateMethod;

      Del allMethodsDelegate = d1 + d2;
      allMethodsDelegate += d3;
      allMethodsDelegate("Test");
      Console.WriteLine();

      allMethodsDelegate -= d1;
      allMethodsDelegate("Test");
      Console.WriteLine();

      Del onwMethodDelegate = allMethodsDelegate - d2;
      onwMethodDelegate("Test");
      Console.WriteLine();

      Console.WriteLine($"d1 == d3: { d1 == d3 }");
      Console.WriteLine($"handler == d3: { handler == d3 }");
      Console.WriteLine();

      DelegateHelper.MethodWithCallback(10, 20, handler);
    }

    static void DelegateMethod(string message)
    {
      Console.WriteLine(message);
    }
  }

  class DelegateHelper
  {
    public static void MethodWithCallback(int param1, int param2, Program.Del callback)
    {
      callback("Toplam: " + (param1 + param2).ToString());
    }
  }

  class MethodClass
  {
    public void Method1(string message)
    {
      Console.WriteLine("Method1");
    }

    public void Method2(string message)
    {
      Console.WriteLine("Method2");
    }
  }
}
