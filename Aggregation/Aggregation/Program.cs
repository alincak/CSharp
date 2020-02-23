using System;

namespace Aggregation
{
  class Program
  {
    static void Main(string[] args)
    {
      var _a = new A();

      var _b = new B(_a);
      var _c = new C(_a);
    }
  }

  class A { }

  class B
  {
    private A m_a { get; set; }
    public B(A a)
    {
      m_a = a;
    }
  }

  class C
  {
    private A m_a { get; set; }

    public C(A a)
    {
      m_a = a;
    }
  }
}
