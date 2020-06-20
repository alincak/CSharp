using System;

namespace ReadonlyKeyword
{
  class Program
  {
    static void Main(string[] args)
    {
      var p1 = new SamplePoint(11, 21, 32);
      Console.WriteLine($"p1: {p1.X}, p2={p1.Y}, p3={p1.Z}");

      var p2 = new SamplePoint();
      p2.X = 55;

      Console.WriteLine($"x: {p2.X}, y={p2.Y}, z={p2.Z}");
    }
  }

  class SamplePoint
  {
    public int X;

    public readonly int Y = 25;
    public readonly int Z;

    public static readonly int A;

    public SamplePoint()
    {
      Z = 24;
    }

    public SamplePoint(int p1, int p2, int p3)
    {
      X = p1;
      Y = p2;
      Z = p3;
    }
  }
}
