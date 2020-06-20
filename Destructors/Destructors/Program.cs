using System;
using System.IO;

namespace Destructors
{
  class Program
  {
    static void Main(string[] args)
    {
      var mc = new MyClass();

      mc.Dispose();
    }
  }

  class MyClass : IDisposable
  {
    private MyClass2[] list;
    private StreamReader reader;

    private bool disposed = false;

    public MyClass()
    {
      this.reader = new StreamReader(@"D:\testfile.txt");

      list = new MyClass2[2];
      list[0] = new MyClass2();
      list[1] = new MyClass2();
    }

    public void Dispose(bool disposing)
    {
      if (!disposed)
      {
        if (disposing)
        {
          if (reader != null)
          {
            reader.Dispose();
          }
        }

        AdditionalCleanup();

        disposed = true;
      }
    }

    private void AdditionalCleanup()
    {
      list = null;

      //or

      if (list != null)
      {
        for (int i = 0; i < list.Length; i++)
        {
          list[i] = null;
        }
      }
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    ~MyClass()
    {
      Dispose(false);
    }
  }

  class MyClass2 { }

}
