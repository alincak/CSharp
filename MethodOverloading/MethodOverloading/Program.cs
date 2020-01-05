using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      CustomConsole.WriteLine("Hello World!");
      CustomConsole.WriteLine(10);
      CustomConsole.WriteLine(true);
      CustomConsole.WriteLine("{0:p}", 0.18);

      Console.ReadKey();
    }
  }

  class CustomConsole
  {
    public static void WriteLine(string a) //WriteLine string
    {
      Console.WriteLine(a);
    }

    public static void WriteLine(int b) //WriteLine int
    {
      Console.WriteLine(b);
    }

    public static void WriteLine(bool b) //WriteLine bool
    {
      Console.WriteLine(b);
    }

    public static void WriteLine(string format, double value) //WriteLine string double
    {
      Console.WriteLine(format, value);
    }
  }
}
