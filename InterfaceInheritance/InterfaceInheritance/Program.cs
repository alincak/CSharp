using System;
using System.Collections;

namespace InterfaceInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      MyClass myClass = new MyClass();

      IA ia = myClass;
      IB ib = myClass;
    }
  }

  interface IA
  { 
    string Text { get; set; }
    void Write();
  }

  interface IB : IA
  {
    void Write();
    void WriteLine();
  }

  class MyClass : IA, IB
  {
    public string Text { get; set; }
    public void Write()
    { 
      //...
    }

    public void WriteLine()
    { 
      //...
    }
  }
}
