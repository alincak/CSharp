using System;

namespace Polymorphism
{
  class Program
  {
    static void Main(string[] args)
    {
      var shapes = new Shape[3];
      shapes[0] = new Rectangle();
      shapes[1] = new Circle();
      shapes[2] = new Triangle();

      foreach (var shape in shapes)
      {
        shape.Draw();
        Console.WriteLine();
      }

      shapes.ToString();
    }
  }

  class Shape
  { 
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public virtual void Draw()
    {
      Console.WriteLine("Sanal metot çizimi.");
    }
  }

  class Circle : Shape
  {
    public override void Draw()
    {
      Console.WriteLine("Daire çizimi");
      base.Draw();
    }
  }

  class Rectangle : Shape
  {
    public override void Draw()
    {
      Console.WriteLine("Dikdörtgen çizimi");
      base.Draw();
    }
  }

  class Triangle : Shape
  {
    public override void Draw()
    {
      Console.WriteLine("Üçgen çizimi");
      base.Draw();
    }
  }


  //----------------------------------------------Ayrı bir örnek

  class A
  {
    public virtual void X(int a) //x,int
    { 
    
    }
  }

  class B : A 
  {
    public override void X(int a)
    {

    }
  }

  class C : B
  {
    public override void X(int ab)
    {

    }
  }
}
