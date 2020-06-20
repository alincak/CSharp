using System;

namespace Sealed
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  sealed class SealedA
  { }

  class MyClass : SealedA
  { }


  class A
  {
    public virtual void F()
    {
      Console.WriteLine("A.F");
    }

    public virtual void F2()
    {
      Console.WriteLine("A.F2");
    }
  }

  class B : A
  {
    public sealed override void F()
    {
      Console.WriteLine("B.F");
    }

    public override void F2()
    {
      Console.WriteLine("B.F2");
    }
  }

  class C : B
  {
    public override void F()
    {
      Console.WriteLine("C.F");
    }

    public override void F2()
    {
      Console.WriteLine("C.F2");
    }
  }
}
