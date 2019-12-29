using System;

namespace ValueReferenceTypes
{
  class Program
  {
    static void Main(string[] args)
    {
      //value type: byte, int,decimal, double, long
      byte a = 5;
      byte b = a;

      Console.WriteLine(++b);
      Console.WriteLine(a);

      int c = 5;

      //reference type: sınıflar
      Test x = new Test();
      Console.WriteLine("Eski x: " + x.a);

      Test y = x;
      y.a = 10;
      Console.WriteLine("y: " + y.a);

      Console.WriteLine("x: " + x.a);

      Console.ReadKey();
    }

    class Test 
    {
      public int a = 5; 
    }

  }
}
