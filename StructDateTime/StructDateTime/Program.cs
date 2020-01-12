using StructDateTime.Helpers;
using System;

namespace StructDateTime
{
  class Program
  {
    static void Main(string[] args)
    {
      var now = DateTime.Now;
      var date = new DateTime(1071, 08, 26);
      var date2 = new DateTime(2023, 10, 29);

      Console.WriteLine($"Kaç yaşında: { DateHelper.CalculateAge(date) }. yıl");

      Console.WriteLine();
      Console.WriteLine($"Gün adı: { DateHelper.GetDayName(date) }");

      DateHelper.WriteDateDiff(date2, now);
    }
  }
}
