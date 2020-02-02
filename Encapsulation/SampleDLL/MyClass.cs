using System;

namespace SampleDLL
{
  public class MyClass
  {
    internal string MyText { get; set; }
  }

  public class MyClassInternal
  {
    public void Sample()
    {
      var myClass = new MyClass();
      myClass.MyText = "";

      var piClass = new MyClassProtectedInternal();
      piClass.PI = "";
    }
  }

  public class MyClassProtectedInternal
  { 
    protected internal string PI { get; set; }
  }
}
