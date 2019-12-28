using System;

namespace SwitchDeyimi
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bir tane paket seçin: 1-küçük, 2-orta, 3-büyük");
      var paket = int.Parse(Console.ReadLine());

      var ucret = 0;

      switch (paket)
      {
        case 1:
          ucret += 25;
          break;
        case 2:
          ucret += 50;
          goto case 1;
        case 3:
        case 4:
          ucret += 75;
          goto case 2;
        default:
          Console.WriteLine("Geçersiz paket.");
          break;
      }

      if (ucret > 0)
      {
        Console.WriteLine("Ucret: " + ucret);
      }

      Console.ReadKey();
    }
  }
}
