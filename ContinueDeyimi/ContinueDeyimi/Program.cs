using System;

namespace ContinueDeyimi
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Bir sayı girin: ");
      var sayi = int.Parse(Console.ReadLine());

      for (var i = 0; i < sayi; i++)
      {
        if (i > 3)
        {
          continue;
        }

        Console.WriteLine(i);
      }

      Console.ReadKey();

    }
  }
}
