using System;
using System.Timers;

namespace EventTimer
{
  class Program
  {
    private static Timer aTimer;

    static void Main(string[] args)
    {
      SetTimer();

      Console.WriteLine("Durdurmak için bir tuşa basın...");
      Console.ReadLine();

      //aTimer.Stop();
      //aTimer.Dispose();
    }

    private static void SetTimer()
    {
      aTimer = new Timer(1000);

      aTimer.Elapsed += OnTimedEvent;
      aTimer.AutoReset = true;
      aTimer.Enabled = true;
    }

    private static void OnTimedEvent(object sender, ElapsedEventArgs e)
    {
      Console.WriteLine(e.SignalTime.ToString());
    }
  }
}
