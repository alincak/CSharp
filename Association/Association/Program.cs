using System;

namespace Association
{
  class Program
  {
    static void Main(string[] args)
    {
      var a = new A();
      var b = new B();

      b.Write(a);
    }
  }

  class A
  {
    public void Write()
    {
      Console.Write("A Sınıfı");
    }

    public void WriteLine()
    {
      Console.WriteLine("A Sınıfı");
    }
  }

  class B
  {
    public void Write(A a)
    {
      a.Write();
    }

    public void WriteLine(A a)
    {
      a.WriteLine();
    }
  }
}
