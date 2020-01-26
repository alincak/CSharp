using System;
using GeometryCalculator;

namespace DLL //Dynamic Link Library
{
  class Program
  {
    static void Main(string[] args)
    {
      var circle = new Circle(10);

      Console.WriteLine($"Alanı: { circle.Area }");
      Console.WriteLine($"Çevresi: { circle.Circumference }");
      Console.WriteLine($"Çapı: { circle.Diameter }");
    }
  }
}
