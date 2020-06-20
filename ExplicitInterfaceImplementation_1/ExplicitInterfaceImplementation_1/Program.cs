using System;

namespace ExplicitInterfaceImplementation_1
{
  class Program
  {
    static void Main(string[] args)
    {
      MyClass myClass = new MyClass();

      I1 i1 = myClass;
      I2 i2 = myClass;

      i1.Write();
      i2.Write();

      Write(myClass);
    }

    public static void Write(I1 i1)
    {
      i1.Write();
    }
  }

  interface I1
  {
    void Write();
  }

  interface I2
  {
    void Write();
  }

  class MyClass : I1, I2
  {
    void I1.Write()
    {
      Console.WriteLine("I1 Write");
    }

    void I2.Write()
    {
      Console.WriteLine("I2 Write");
    }
  }
}
