using System;

namespace Nested
{
  class Program
  {
    static void Main(string[] args)
    {
      var sample = new Sample();

      Console.WriteLine($"Sample X: { sample.X }");
      Console.WriteLine($"NestedSample X: { sample.NestedSampleX }");

      Console.ReadKey();
    }
  }

  class Sample
  { 
    public int X { get; private set; }
    public int NestedSampleX { get; private set; }

    public Sample()
    {
      X = 5;
      NestedSampleX = new NestedSample().X;
    }

    class NestedSample
    { 
      public int X { get; set; }

      public NestedSample()
      {
        X = 10;
      }
    }
  }

}
