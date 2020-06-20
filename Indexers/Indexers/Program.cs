using System;

namespace Indexers
{
  class Program
  {
    static void Main(string[] args)
    {
      var week = new DayCollection();

      Console.WriteLine("Indexer Day: {0}", week["Fri"]);
      Console.WriteLine("Indexer Index: {0}", week[1]);
    }
  }

  class DayCollection
  {
    string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };

    public string GetIndex { get; set; }

    public string this[int index]
    {
      get
      {
        return days[index];
      }
    }

    public int this[string day]
    {
      get
      {
        return FindDayIndex(day);
      }
    }

    private int FindDayIndex(string day)
    {
      for (int i = 0; i < days.Length; i++)
      {
        if (days[i] == day)
        {
          return i;
        }
      }

      throw new ArgumentOutOfRangeException(nameof(day), "Bulunamadı.");
    }
  }

}
