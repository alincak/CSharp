using System;

namespace ParamsKeywords
{
  class Program
  {
    static void Main(string[] args)
    {
      UseParams(1, 5, 7, 15);

      int[] intArr = { 1, 2, 6, 9, 11 };
      UseParams(10, intArr);

      UseParams(10);
    }

    static void UseParams(int a, params int[] list)
    {
      foreach (var item in list)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine();
    }
  }
}
