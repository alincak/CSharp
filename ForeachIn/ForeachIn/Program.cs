using System;

namespace ForeachIn
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new int[5] { 1, 2, 3, 4, 5 };

      Console.Write("Çıktı:");
      for (var i = 0; i < arr.Length; i++)
      {
        Console.Write($" { arr[i] } ");
      }

      Console.WriteLine();

      Console.Write("Çıktı:");
      foreach (var item in arr)
      {
        Console.Write($" { item } ");
      }
    }
  }
}
