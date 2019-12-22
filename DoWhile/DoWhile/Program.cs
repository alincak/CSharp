using System;

namespace DoWhile
{
  class Program
  {
    static void Main(string[] args)
    {
      Iste();
    }

    static void Iste()
    {
      var x = 0;
      do
      {
        Console.Write("Çift sayı girin:");
        x = int.Parse(Console.ReadLine());
      } while (x % 2 != 0);
    }
  }
}
