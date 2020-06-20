using System;
using System.Security.Cryptography.X509Certificates;

namespace ExplicitInterfaceImplementation_3
{
  class Program
  {
    static void Main(string[] args)
    {
      MyClass myClass = new MyClass();
      myClass.X = 10;

      I2 i2 = myClass;

      Console.WriteLine("I1.X => " + myClass.X);
      Console.WriteLine("I2.X() => " + i2.X());
    }
  }

  interface I1
  {
    int X { get; set; }
  }

  interface I2
  {
    int X();
  }

  class MyClass : I1, I2
  {
    private int x;
    public int X
    {
      get
      {
        return x;
      }
      set
      {
        x = value;
      }
    }

    int I2.X()
    {
      return x;
    }
  }
}
