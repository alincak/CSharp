using System;

namespace SinifVeriElamanlari
{
  class Program
  {
    static void Main(string[] args)
    {
      var s = new Test();
      s.a = 10;
      s.b = 15;

      var s1 = new Test();
      s1.a = 15;
      s1.b = 12;

      Console.WriteLine(string.Format("s.a: {0}, s.b: {1}", s.a, s.b));
      Console.WriteLine(string.Format("s1.a: {0}, s1.b: {1}", s1.a, s1.b));

      Console.ReadKey();
    }
  }

  class Test 
  {
    public int a;
    public int b;
  }

}
