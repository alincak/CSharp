using System;

namespace ConstructorBase
{
  class Program
  {
    static void Main(string[] args)
    {
      var b = new B();

      Console.WriteLine();
      Console.WriteLine();

      var b1 = new B("Toplam işlemi", 5, 7);
    }
  }

  class A
  {
    public A()
    {
      Console.WriteLine("A default constructor");
    }

    public A(int a, int b)
    {
      Console.WriteLine($"A int,int constructor - Toplam: { a + b }");
    }
  }

  class B : A
  {
    public B()
    {
      Console.WriteLine("B default constructor");
    }

    public B(string text, int a, int b) : base(a, b)
    {
      Console.WriteLine($"B string,int,int constructor - Text: { text }");
    }
  }
}
