using System;

namespace SingleDimensionalArray
{
  class Program
  {
    static void Main(string[] args)
    {
      var array1 = new int[] { 1, 3, 5, 7, 9 };
      var weekDays = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

      int[] array2 = { 1, 3, 5, 6 };
      string[] weekDays2 = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

      for (var i = 0; i < array2.Length; i++)
      {
        var weekDayIndex = array2[i];
        Console.WriteLine($"{ weekDays2[weekDayIndex] }");
      }

      var array = new int[5];
      array[0] = 1;
    }
  }
}
