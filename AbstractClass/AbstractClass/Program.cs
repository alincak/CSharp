using System;

namespace AbstractClass
{
  class Program
  {
    static void Main(string[] args)
    {
      var square = new Square(10);
      square.GetArea();
      square.Write();
    }
  }

  abstract class Shape
  {
    public abstract int GetArea();

    public void Write()
    {
      Console.WriteLine("Write");
    }
  }

  class Square : Shape
  { 
    private int Side { get; set; }

    public Square(int n)
    {
      Side = n;
    }

    public override int GetArea()
    {
      return Side * Side;
    }
  }
}
