using System;
using System.Globalization;

namespace StructDateTime.Helpers
{
  public static class DateHelper
  {
    public static int CalculateAge(DateTime date)
    {
      var now = DateTime.Now;
      var age = now.Year - date.Year;

      if (date > now.AddYears(-age))
      {
        age--;
      }

      return age;
    }

    public static void WriteDateDiff(DateTime date, DateTime date2)
    {
      var totalDays = (date - date2).TotalDays;

      var totalYears = Math.Truncate(totalDays / 365);
      var totalMonths = Math.Truncate((totalDays % 365) / 30);
      var remainingDays = Math.Truncate((totalDays % 365) % 30);

      Console.WriteLine();
      Console.WriteLine($"{ totalYears } Yıl, { totalMonths } Ay, { remainingDays } Gün kalmış.");
    }

    public static string GetDayName(DateTime date, string cultureName = "tr-TR")
    {
      return CultureInfo.GetCultureInfo(cultureName).DateTimeFormat.DayNames[(int)date.DayOfWeek];
    }

  }
}
