using System;

namespace ForDongusu
{
  class Program
  {
    static void Main(string[] args)
    {
      Yaz3();

      Console.ReadKey();
    }

    static void Yaz()
    {
      for (var i = 0; i < 10; i++)
      {
        Console.WriteLine(i);
      }
    }

    static void Yaz2()
    {
      var i = 0;
      for (; i < 10; i++)
      {
        Console.WriteLine(i);
      }
    }

    static void Yaz3()
    {
      var i = 0;
      for (; i < 10;)
      {
        Console.WriteLine(i);
        i++;
      }

      //While benzerliği
      //while (i < 10)
      //{
      //  Console.WriteLine(i);
      //  i++;
      //}
    }

    static void Yaz4()
    {
      for (var i = 0; ; i++)
      {
        Console.WriteLine(i);
      }

      //var i = 0;
      //while (true)
      //{
      //  Console.WriteLine(i);
      //  i++;
      //}
    }

    static void Yaz5()
    {
      for (; ; );

      while (true) ;
    }

  }
}
