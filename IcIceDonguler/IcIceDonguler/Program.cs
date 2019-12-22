using System;

namespace IcIceDonguler
{
  class Program
  {
    static void Main(string[] args)
    {
      Yaz();
    }

    static void Yaz()
    {
      for (var i = 0; i < 10; i++)
      {
        for (var k = 0; k < 2; k++)
        {
          var text = string.Format("i: {0}, k: {1}", i, k);
          Console.WriteLine(text);
        }
      }

      Console.ReadKey();
    }

  }
}
