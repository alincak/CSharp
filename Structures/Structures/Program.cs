using System;

namespace Structures
{
  class Program
  {
    static void Main(string[] args)
    {
      var customDateTime1 = new CustomDateTime();
      var customDateTime2 = new CustomDateTime(30, 03, 1432);
      CustomDateTime customDateTime3;

      customDateTime3.Day = 20;
      customDateTime3.Month = 01;
      customDateTime3.Year = 1029;

      Console.Write("customDateTime1: ");
      Console.WriteLine($"Gün: { customDateTime1.Day }, Ay: { customDateTime1.Month }, Yıl: { customDateTime1.Year }");

      Console.Write("customDateTime2: ");
      Console.WriteLine($"Gün: { customDateTime2.Day }, Ay: { customDateTime2.Month }, Yıl: { customDateTime2.Year }");

      Console.Write("customDateTime3: ");
      Console.WriteLine($"Gün: { customDateTime3.Day }, Ay: { customDateTime3.Month }, Yıl: { customDateTime3.Year }");

    }
  }

  struct CustomDateTime
  {
    public int Day, Month, Year;

    public CustomDateTime(int day, int month, int year)
    {
      Day = day;
      Month = month;
      Year = year;
    }

    public void AddDays(int value)
    {
      Day += value;
    }
  }
}
