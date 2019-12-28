using System;

namespace BreakDeyimi
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

      for (var i = 0; i < numbers.Length; i++)
      {
        Console.WriteLine(string.Format("Sayi: {0}", numbers[i]));
        for (var k = 0; k < letters.Length; k++)
        {
          if (i == k)
          {
            break;
          }
          Console.Write(string.Format("{0}", letters[k]));
        }
        Console.WriteLine();
      }

      Console.ReadKey();

    }
  }
}
