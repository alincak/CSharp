using System;

namespace ElseIfDeyimi
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Bir sayı girin:");
      var x = int.Parse(Console.ReadLine());

      Console.WriteLine(Cevir(x));
      Console.WriteLine(Cevir1(x));

      Console.ReadKey();
    }

    static string Cevir(int x)
    {
      if (x < 0)
        return "Sıfırdan küçük";
      else
        if (x == 1)
          return "Bir";
        else
          if (x == 2)
            return "İki";
          else
            if (x == 3)
              return "Üç";
            else
              return "Büyük bir sayı girdiniz.";
    }

    static string Cevir1(int x)
    {
      if (x < 0)
      {
        return "Sıfırdan küçük";
      }
      else if (x == 1)
      {
        return "Bir";
      }
      else if (x == 2)
      {
        return "İki";
      }
      else if (x == 3)
      {
        return "Üç";
      }
      else 
      {
        return "Büyük bir sayı girdiniz";
      }
    }

  }
}
