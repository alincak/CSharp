using static System.Math;

namespace UsingSample
{
  class Circle
  {
    public double Radius { get; set; }

    public Circle(double radius)
    {
      Radius = radius;
    }

    public double Area
    {
      get
      {
        return PI * Pow(Radius, 2);
      }
    }

  }
}
