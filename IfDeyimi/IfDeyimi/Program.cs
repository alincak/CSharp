using System;

namespace IfDeyimi
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Bir sayı girin:");

      var x = int.Parse(Console.ReadLine());

      Sayi(x);
      Sayi1(x);
      Sayi2(x);

      Console.WriteLine(Sayi3(x));

      Console.ReadKey();
    }

    static void Sayi(int x)
    {
      if (x > 0)
      {
        Console.WriteLine("Sayi - Pozitif");
        Console.WriteLine("Sayi - Pozitif2");
      }
      else
      {
        Console.WriteLine("Sayi - Negatif");
      }
    }

    static void Sayi1(int x)
    {
      if (x > 0)
        Console.WriteLine("Sayi1 - Pozitif");
      else
        Console.WriteLine("Sayi1 - Negatif");
    }

    static void Sayi2(int x)
    {
      if (x > 0)
        Console.WriteLine("Sayi2 - Pozitif");
      else
      {
        Console.WriteLine("Sayi2 - Negatif");
      }
    }

    static string Sayi3(int x)
    {
      if (x > 0)
      {
        return "Sayi3 - Pozitif";
      }

      return "Sayi3 - Negatif";
    }

  }
}
