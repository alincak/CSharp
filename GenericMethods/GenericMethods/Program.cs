using System;

namespace GenericMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      var intArr = new int[5] { 10, 5, 7, 12, 9 };
      var intMax = GenericHelper.GetMax(intArr);

      Console.WriteLine("Int Max: {0}", intMax);

      var longArr = new long[5] { 15, 2, 12, 9, 24 };
      var longMax = GenericHelper.GetMax(longArr);

      Console.WriteLine("Long Max: {0}", longMax);

      Console.WriteLine();
      Console.WriteLine("----Sonrası Generic----");
      Console.WriteLine();

      var gIntMax = GenericHelper.GetMax<int>(intArr);
      Console.WriteLine("Generic Int Max: {0}", gIntMax);

      var gLongMax = GenericHelper.GetMax<long>(longArr);
      Console.WriteLine("Generic Long Max: {0}", gLongMax);
    }
  }

  static class GenericHelper
  {
    public static int GetMax(int[] arr)
    {
      var max = int.MinValue;

      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] > max)
        {
          max = arr[i];
        }
      }

      return max;
    }

    public static long GetMax(long[] arr)
    {
      var max = long.MinValue;

      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] > max)
        {
          max = arr[i];
        }
      }

      return max;
    }

    public static T GetMax<T>(T[] arr) where T : IComparable
    {
      var max = arr[0];

      for (int i = 1; i < arr.Length; i++)
      {
        if (max.CompareTo(arr[i]) < 0)
        {
          max = arr[i];
        }
      }

      return max;
    }

  }
}
