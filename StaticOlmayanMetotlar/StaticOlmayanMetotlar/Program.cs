using System;

namespace StaticOlmayanMetotlar
{
  class Program
  {
    static void Main(string[] args)
    {
      var numbers = new Numbers();

      var x = numbers.Random();
      var y = numbers.Random();

      Console.WriteLine(string.Format("x: {0}, y: {1}", x, y));

      var min = Numbers.FindMinimum(x, y);
      Console.WriteLine(string.Format("Min: {0}", min));

      Console.ReadKey();
    }
  }

  class Numbers
  {
    Random rnd;

    public int Random()
    {
      rnd = rnd == null ? new Random() : rnd;
      return rnd.Next(0, 100);
    }

    public static int FindMinimum(int number1, int number2)
    {
      return number1 < number2 ? number1 : number2;
    }
  }
}
