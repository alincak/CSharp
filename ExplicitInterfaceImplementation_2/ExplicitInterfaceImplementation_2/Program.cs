using System;

namespace ExplicitInterfaceImplementation_2
{
  class Program
  {
    static void Main(string[] args)
    {
      MyDrawClass myDraw = new MyDrawClass();

      IPyramid pyramid = myDraw;
      pyramid.Draw();

      Console.WriteLine();
      Console.WriteLine();

      ISquare square = myDraw;
      square.Draw();
    }
  }

  interface ISquare
  {
    void Draw();
  }

  interface IPyramid
  {
    void Draw();
  }

  class MyDrawClass : IPyramid, ISquare
  {
    void IPyramid.Draw()
    {
      for (int i = 1; i <= 10; i++)
      {
        for (int k = i; k < 10; k++)
          Console.Write(" ");

        for (int j = 1; j <= (2 * i - 1); j++)
          Console.Write("*");

        Console.WriteLine();
      }
    }

    void ISquare.Draw()
    {
      var sideLength = 10;
      for (int row = 1; row <= sideLength; row++)
      {
        for (int col = 1; col <= sideLength; col++)
        {
          if (col <= row)
            Console.Write('*');
          else
            Console.Write('*');
        }
        Console.WriteLine();
      }
    }
  }
}
