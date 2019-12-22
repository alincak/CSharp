using System;

namespace WhileDongusu
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Bir sayı giriniz:");

      var x = int.Parse(Console.ReadLine());

      //Yaz(x);
      Yaz1(x);

      Console.ReadKey();
    }

    static void Yaz(int x)
    {
      while (x > 0)
      {
        Console.WriteLine(x);
        --x;
      }
    }

    static void Yaz1(int x)
    {
      while (x > 0)
        Console.WriteLine(x--);
    }

  }
}
