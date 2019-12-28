using System;

namespace Goto
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Bir sayı girin: ");
      var sayi = int.Parse(Console.ReadLine());

      for (var i = 0; i < sayi; i++)
      {
        Console.WriteLine("Sayi: " + i);
        if (i == 8)
        {
          goto Found;
        }
      }

    Found:
      Console.WriteLine("Buldum.");

      Console.ReadKey();
    }
  }
}
