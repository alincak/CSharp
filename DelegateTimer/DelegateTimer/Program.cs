using System;
using System.Threading;

namespace DelegateTimer
{
  class Program
  {
    static void Main(string[] args)
    {
      StartTimer(1000);
      Console.WriteLine("Çıkış için enter...");
      Console.ReadLine();
    }

    public static void StartTimer(int dueTime)
    {
      var timer = new Timer(TimerProc);
      timer.Change(dueTime, 0);
    }

    private static void TimerProc(object state)
    {
      Console.WriteLine(DateTime.Now.ToString());
      StartTimer(1000);
    }
  }
}
