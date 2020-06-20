using System;

namespace Interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Interfaces
       * Tüm elemanları default public'tir. Yani arayüzlerde erişim belirleyicisi belirtilmez.
       * Arayüz elemanları(mettotlar, property'ler) gövde içermez.
       * Virtual veya abstract belirleyicileri ile bildirilemezler.
       * Static elemanlara sahip olamazlar.
       */

      B b = new B();
      b.SampleMethod();

      IAInterface i = b;
      i.SampleMethod();

      //IAInterface i1 = new IAInterface(); error
    }

    interface IAInterface
    { 
      int X { get; set; }
      void SampleMethod();
    }

    interface IBInterface
    { 
      int Y { get; set; }
    }

    class A : IAInterface
    { 
      public int X { get; set; }
      void IAInterface.SampleMethod()
      { 
        //...
      }
    }

    class B : IAInterface
    { 
      public int X { get; set; }
      public void SampleMethod()
      {
        Console.WriteLine("IAInterface.SampleMethod");
      }
    }

    class C
    {
      public void SampleMethod()
      { 
      
      }
    }

    class D : C, IAInterface
    { 
      public int X { get; set; }
    }

    struct S : IAInterface //Yapılar türemez ama desteklenebilir.
    { 
      public int X { get; set; }
      public void SampleMethod()
      { 
      
      }
    }

    class E : IAInterface, IBInterface
    {
      public int X { get; set; }
      public void SampleMethod()
      { 
      
      }

      public int Y { get; set; }
    }

  }
}
