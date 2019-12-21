using System;

namespace Metotlar
{
  class Program
  {
    static void Main(string[] args)
    {
      Yaz();

      Console.WriteLine(Pozitif(-1));

      Console.ReadKey();
    }

    public static void Yaz()
    {
      Console.WriteLine("Yazdım.");
    }

    public static string Pozitif(int x)
    {
      return x > 0 
        ? "Pozitif" 
        : "Negatif";
    }

  }
}
