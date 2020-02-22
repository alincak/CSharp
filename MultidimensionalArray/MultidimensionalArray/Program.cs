using System;

namespace MultidimensionalArray
{
  class Program
  {
    static void Main(string[] args)
    {
      var array2D = Get2DArray(5, 25);
      for (var row = 0; row < array2D.GetLength(0); row++)
      {
        for (var col = 0; col < array2D.GetLength(1); col++)
        {
          Console.Write(array2D[row, col]);
        }
        Console.WriteLine();
      }

      //üç boyutlu: int[,,]
    }

    static int[,] Get2DArray(int rowCount, int colCount)
    {
      var array2D = new int[rowCount, colCount];

      var length1 = array2D.GetLength(0);
      var length2 = array2D.GetLength(1);
      for (var row = 0; row < length1; row++)
      {
        for (var col = 0; col < length2; col++)
        {
          if (row == 0 || col == 0 || row == length1 - 1 || col == length2 - 1)
          {
            array2D[row, col] = 1;
          }
        }
      }

      return array2D;
    }
  }
}
