using System;
using System.IO;

namespace TryFinally
{
  class Program
  {
    static void Main(string[] args)
    {
      TestFinally();
    }

    static void TestFinally()
    {
      FileStream file = null;
      var fileInfo = new FileInfo(@"D:\udemyprojects\TryFinally\TryFinally\Files\TextFile1.txt");

      try
      {
        file = fileInfo.OpenRead();
        //...

        return;
      }
      catch (IOException ex)
      {
        Console.WriteLine("OpenRead() failed. Ex: {0}", ex);
        return;
      }
      finally
      {
        Console.WriteLine("OpenRead() finally");
        if (file != null)
        {
          Console.WriteLine("OpenRead() finally file close");
          file.Close();
        }
      }
    }
  }
}
