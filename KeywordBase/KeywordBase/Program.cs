using System;

namespace KeywordBase
{
  class Program
  {
    static void Main(string[] args)
    {
      var b = new B();
      b.Write();
    }
  }

  class A
  { 
    protected string val { get { return "A"; } }
  }

  class B : A
  {
    private new string val { get { return "B"; } }

    public void Write()
    {
      Console.WriteLine(val);
      Console.WriteLine(base.val);
    }
  }
}
