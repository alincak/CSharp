using System;

namespace Comments
{
  class Program
  {
    static void Main(string[] args)
    {
      //Yorum satırı.

      /*
        satır1
        satır2
       */

      Method(10, 10, "");
    }

    /// <summary>
    /// Methodun açıklaması.
    /// </summary>
    /// <param name="x">Parametre "x"</param>
    /// <param name="y">Parametre "y"</param>
    /// <param name="w">Parametre "w"</param>
    /// <returns>int tipinden geri dönüş.</returns>
    static int Method(int x, int y, string w)
    {
      return 0;
    }

  }
}
