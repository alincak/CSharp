using System;

namespace KeywordNull
{
  class Program
  {
    static void Main(string[] args)
    {
      MyClass mc;

      //if (mc == null) { }

      mc = null;
      if (mc == null) { }

      string s = null;
      string t = string.Empty;

      bool b = t.Equals(s);
      Console.WriteLine(b);

      int? c = null;
      if (c == null)
      {
        Console.WriteLine("i null");
      }

      Console.WriteLine(c.GetValueOrDefault());
    }
  }

  class MyClass { }
}
