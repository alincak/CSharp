using System;
using System.Net.Http.Headers;

namespace ConstKeywords
{
  class Program
  {
    static void Main(string[] args)
    {
      var sc = new SampleClass(11, 22);
      Console.WriteLine($"x = { sc.X }, y = { sc.Y }");
      Console.WriteLine($"C1 = { SampleClass.C1 }, C2 = { SampleClass.C2 }");

      const int C = 707;
      Console.WriteLine($"Yerel: { C }");
    }
  }

  class SampleClass
  {
    public int X;
    public int Y;
    public const int C1 = 5;
    public const int C2 = C1 + 5;

    //private const double x = 1, y = 3, z = 3;

    public SampleClass(int p1, int p2)
    {
      X = p1;
      Y = p2;
    }
  }
}
