using System;

namespace JaggedArrays
{
  class Program
  {
    static void Main(string[] args)
    {
      int[][] arr = new int[2][];

      arr[0] = new int[5] { 1, 3, 5, 7, 9 };
      arr[1] = new int[4] { 2, 4, 6, 8 };

      for (int i = 0; i < arr.Length; i++)
      {
        Console.Write($"Elemanlar({ i }): ");

        var _subLength = arr[i].Length;
        for (int j = 0; j < _subLength; j++)
        {
          var _empty = j == (_subLength - 1) ? "" : " ";
          Console.Write($"{ arr[i][j] } { _empty }");
        }
        Console.WriteLine();
      }
      
    }
  }
}
