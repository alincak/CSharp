using System;

namespace AyniTurSinifAtamasi
{
  class Program
  {
    static void Main(string[] args)
    {
      Tarih x, y;

      x = new Tarih();
      x.Gun = 12;
      x.Ay = 1;
      x.Yil = 2019;

      y = x;

      Console.WriteLine(string.Format("Gun: {0}, Ay: {1}, Yıl: {2}", y.Gun, y.Ay, y.Yil));

      Console.ReadKey();
    }
  }

  class Tarih
  {
    public int Gun;
    public int Ay;
    public int Yil;
  }

}
