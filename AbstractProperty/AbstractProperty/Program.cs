using System;

namespace AbstractProperty
{
  class Program
  {
    static void Main(string[] args)
    {
      var b = new B();
      b.AbstractMethod();

      Console.WriteLine($"x = { b.X }, y = { b.Y }");
    }
  }

  abstract class A
  {
    protected int _x = 100;
    protected int _y = 150;

    public abstract void AbstractMethod();

    public abstract int X { get; }
    public abstract int Y { get; }

    public abstract int Z { get; set; }
  }

  class B : A
  {
    public override void AbstractMethod()
    {
      _x++;
      _y++;
    }

    public override int X { get { return _x; } }
    public override int Y { get { return _y; } }

    public override int Z { get; set; }
  }
}
