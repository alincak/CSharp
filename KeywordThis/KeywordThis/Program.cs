using System;

namespace KeywordThis
{
  class Program
  {
    static void Main(string[] args)
    {
      var myClass = new MyClass("Test", "LastTest");
      myClass.Write();
    }
  }

  class MyClass
  {
    private string name { get; set; }
    private string lastName { get; set; }
    public string GetDisplayName { get { return string.Format("{0} {1}", name, lastName); } }

    public MyClass(string name, string lastName)
    {
      this.name = name;
      this.lastName = lastName;
    }

    public void Write()
    {
      WriteHelper.Write(this);
    }
  }

  static class WriteHelper
  { 
    public static void Write(MyClass myClass) 
    {
      Console.WriteLine(myClass.GetDisplayName);
    }
  }
}
