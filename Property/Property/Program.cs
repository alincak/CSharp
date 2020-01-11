using System;

namespace Property
{
  class Program
  {
    static void Main(string[] args)
    {
      var t = new TimePeriodProperty();
      t.Hours = 24;

      Console.WriteLine($"Hours: { t.Hours }");
      Console.WriteLine($"Second: { t.Seconds }");

      //Console.WriteLine(string.Format("Hours: {0}", t.GetHours()));

      Console.ReadKey();
    }
  }

  class TimePeriodProperty
  {
    //private double _seconds;

    public double Seconds { get; private set; }

    //public double Seconds
    //{
    //  get { return _seconds; }
    //}

    public double Hours
    {
      get { return Seconds / 3600; }
      set
      {
        if (value < 0 || value > 24)
        {
          Seconds = 0;
          return;
        }
        Seconds = value * 3600;
      }
    }
  }

  class TimePeriod
  {
    private double _seconds;

    public double GetSeconds()
    {
      return _seconds;
    }

    public double GetHours()
    {
      return _seconds / 3600;
    }

    public void SetSeconds(int hours)
    {
      if (hours < 0 || hours > 24)
      {
        _seconds = 0;
        return;
      }
      _seconds = hours * 3600; 
    }
  }
}
