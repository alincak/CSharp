using System;

namespace Composition
{
  class Program
  {
    //İçerilen nesne tek bir nesne tarafından içerilmelidir. Birden fazla nesne tarafından içirilemez
    //İçerilen nesne ile içeren nesnenin ömürleri yaklaşık aynıdır

    static void Main(string[] args)
    {
      {
        var _b = new B();
      }
    }
  }

  class A
  { 
    //...
  }

  class B
  {
    private A m_a { get; set; }

    public B()
    {
      m_a = new A();
    }
  }
}
