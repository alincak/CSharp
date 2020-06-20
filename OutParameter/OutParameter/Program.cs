using System;

namespace OutParameter
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new string[5] { "a", "b", "c", "d", "e" };
      if (GetValue(arr, 2, out string val))
      {
        Console.WriteLine("Değer: {0}", val);
        return;
      }

      Console.WriteLine("Bulunamadı.");

      var str = "123";
      if (int.TryParse(str, out int result))
      {
        //...
      }
    }

    static bool GetValue(string[] arr, int index, out string val)
    {
      val = null;

      try
      {
        val = arr[index];
        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}
