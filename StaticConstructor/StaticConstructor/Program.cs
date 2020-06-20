using System;

namespace StaticConstructor
{
  class Program
  {
    static void Main(string[] args)
    {
      var bus = new Bus(10);
    }
  }

  public class Bus
  {
    public static readonly DateTime GlobalStartTime;

    private int BusNumber;

    static Bus()
    {
      GlobalStartTime = DateTime.Now;
      Console.WriteLine("Static constructor, Date: {0}", GlobalStartTime.ToLongTimeString());
    }

    public Bus(int busNumber)
    {
      BusNumber = busNumber;
      Console.WriteLine("Instance constructor, Bus number: {0}", BusNumber);
    }
  }
}
