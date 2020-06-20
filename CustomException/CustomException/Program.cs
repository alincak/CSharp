using System;

namespace CustomException
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Main başladı");

      try
      {
        TestThrow(1);
      }
      catch (CustomException cex)
      {
        Console.WriteLine("CustomException bloğu: CustomMessage: {0}, message: {1}", cex.CustomMessage, cex.Message);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Exception bloğu: {0}", ex.Message);
      }

      Console.WriteLine("Main çıkış");
    }

    private static void TestThrow(int type)
    {
      Console.WriteLine("TestThrow başladı");

      if (type == 0)
      {
        throw new CustomException("Custom exception");
      }

      throw new Exception("Exception");
    }
  }

  class CustomException : Exception
  {
    public CustomException(string message) : base(message)
    {
      CustomMessage = message;
    }

    public string CustomMessage { get; private set; }
  }
}
