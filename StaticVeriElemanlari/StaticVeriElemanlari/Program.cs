using System;

namespace StaticVeriElemanlari
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(string.Format("En yüksek değer: {0}", RasgeleSayi.EnYuksek));

      Console.ReadKey();
    }
  }

  class RasgeleSayi
  {
    public static int EnYuksek = 100;

    public int Olustur()
    {
      return 0;
    }
  }

}
