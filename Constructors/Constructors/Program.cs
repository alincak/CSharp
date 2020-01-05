using System;

namespace Constructors
{
  class Program
  {
    static void Main(string[] args)
    {
      var generate = new GenerateRandom();

      var a = generate.Random();
      var b = generate.Random(10);
      var c = generate.Random(11, 100);

      Console.WriteLine("a: {0}, b: {1}, c: {2}", a, b, c);

      var random = new Random();
      var generate2 = new GenerateRandom(random);

      var a2 = generate2.Random();
      var b2 = generate2.Random(10);
      var c2 = generate2.Random(11, 100);

      Console.WriteLine("a2: {0}, b2: {1}, c2: {2}", a2, b2, c2);

      Console.ReadKey();
    }
  }

  class GenerateRandom
  {
    Random rnd;

    public GenerateRandom()
    {
      rnd = new Random();
      Console.WriteLine("GenerateRandom");
    }

    public GenerateRandom(Random random)
    {
      rnd = random;
      Console.WriteLine("GenerateRandom Random");
    }

    public int Random()
    {
      return rnd.Next();
    }

    public int Random(int maxValue)
    {
      return rnd.Next(maxValue);
    }

    public int Random(int minValue, int maxValue)
    {
      return rnd.Next(minValue, maxValue);
    }
  }
}
