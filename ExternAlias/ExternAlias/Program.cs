extern alias AliasDLL1;
using System;

namespace ExternAlias
{
  class Program
  {
    static void Main(string[] args)
    {
      var myClass1 = new AliasDLL1::Sample.MyClass();
      myClass1.Write();

      var myClass2 = new Sample.MyClass();
      myClass2.Write();

    }
  }
}
