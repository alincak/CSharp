using System;

namespace Exceptions
{
  class Program
  {
    static void Main(string[] args)
    {
      var _value = GetValue(new string[] { "a", "b", "c" }, 3);
      Console.WriteLine(_value);
    }

    static string GetValue(string[] array, int index)
    {
      try
      {
        return array[index];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }

      return null;
    }
  }
}

/*
 -------Try Catch Yazım örnekleri;

 //try, catch, throw, finally

      try
      {
        //...
      }
      catch (Exception)
      { throw; }

      try
      {
        //...
      }
      catch
      { }
      finally
      { }

      try
      {
        //...
      }
      finally
      { }

      try
      {
        //...
      }
      catch (FormatException)
      { }
      catch (Exception)
      { }
   */
