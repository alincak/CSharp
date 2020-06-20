using System;

namespace IsOperator
{
  class Program
  {
    static void Main(string[] args)
    {
      var b = new Base();
      Console.WriteLine("b is Base : " + (b is Base));
      Console.WriteLine("b is Derived : " + (b is Derived));

      //var _d = (Derived)b;

      Console.WriteLine();

      var d = new Derived();
      Console.WriteLine("d is Base : " + (d is Base));
      Console.WriteLine("d is Derived : " + (d is Derived));

      if (d is Base)
      {
        var _base = (Base)d;
      }

    }
  }

  public class Base { }

  public class Derived : Base { }
}
