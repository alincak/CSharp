using System;
using System.Security.Cryptography.X509Certificates;

namespace Event
{
  delegate void Write(string message);

  class Program
  {
    static void Main(string[] args)
    {
      var prop = new Prop(new string[] { "a", "b", "c" });
      Console.WriteLine(prop.Next);
      Console.WriteLine(prop.Next);
      Console.WriteLine();

      var delEvent = new DelegateEvent();
      delEvent.E += Test;

      delEvent.ConsoleWrite("DelegateEvent");

      var delEvent2 = new DelegateEvent2();
      delEvent2.E += Test;

      delEvent2.ConsoleWrite("DelegateEvent2");
    }

    public static void Test(string message)
    {
      Console.WriteLine(message);
    }
  }

  class Prop
  { 
    private string[] m_array { get; set; }
    private int m_index { get; set; }

    public Prop(string[] array)
    {
      m_array = array;
    }

    public string Next
    {
      get 
      {
        var _val = m_array[m_index];
        m_index++;

        return _val;
      }
    }
  }

  class DelegateEvent
  {
    private Write m_Write;

    public event Write E
    {
      add
      {
        //...
        m_Write += value;
      }

      remove
      {
        //...
        m_Write -= value;
      }
    }

    public void ConsoleWrite(string message)
    {
      m_Write(message);
      Console.WriteLine();
    }
  }

  class DelegateEvent2
  {
    public event Write E;

    public void ConsoleWrite(string message)
    {
      E(message);
      Console.WriteLine();
    }
  }

}
