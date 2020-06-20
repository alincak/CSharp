using System;

namespace IndexerInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      var test = new IndexerClass();
      var rand = new Random();

      for (int i = 0; i < 2; i++)
      {
        for (int k = 0; k < 2; k++)
        {
          test[i, k] = rand.Next(100);
        }
      }

      for (int i = 0; i < 2; i++)
      {
        for (int k = 0; k < 2; k++)
        {
          Console.WriteLine($"Eleman #{i},{k} = { test[i, k] }");
        }
      }
    }
  }

  public interface IIndexerInterface
  { 
    int this[int x, int y] 
    {
      get;
      set;
    }
  }

  class IndexerClass : IIndexerInterface
  {
    private int[,] arr = new int[2, 2];

    public int this[int x, int y]
    {
      get
      {
        return arr[x, y];
      }

      set
      {
        arr[x, y] = value;
      }
    }
  }
}
