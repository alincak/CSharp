using System;

namespace GeometryCalculator
{
  public class Circle
  {
    private double m_radius { get; set; }

    public Circle(double radius)
    {
      m_radius = radius;
    }

    public double Diameter
    {
      get { return 2 * m_radius; }
    }

    public double Circumference
    {
      get { return 2 * m_radius * Math.PI; }
    }

    public double Area
    {
      get
      {
        return Math.PI * Math.Pow(m_radius, 2);
      }
    }
  }
}
