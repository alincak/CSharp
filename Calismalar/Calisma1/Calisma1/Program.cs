using System;

namespace Calisma1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Üçgenin uzunluğu: ");
      var number = int.Parse(Console.ReadLine());

      Console.WriteLine("Sembol girin: ");
      var symbol = Console.ReadLine();

      Console.WriteLine();

      for (int i = 1; i < number; i++)
      {
        PrintTriangle(1, i, symbol);
      }

      for (int i = number; i >= 1; i--)
      {
        PrintTriangle(1, i, symbol);
      }
      Console.WriteLine();
    }

    static void PrintTriangle(int start, int end, string simbol)
    {
      Console.WriteLine();
      for (int j = start; j <= end; j++)
      {
        Console.Write(simbol + " ");
      }
    }

  }
}
