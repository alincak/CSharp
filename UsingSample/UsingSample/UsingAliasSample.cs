
using Alias1MyClass = Namespace1.MyClass;
using Alias2MyClass = Namespace2.MyClass;

namespace UsingSample
{
  class UsingAliasSample
  {
    void Sample()
    {
      //var myClass = new Namespace1.MyClass();
      var myClass1 = new Alias1MyClass();
      myClass1.Write();

      var myClass2 = new Alias2MyClass();
      myClass2.Write();
    }
  }
}

namespace Namespace1
{
  public class MyClass
  {
    public void Write()
    { 
      //...
    }
  }
}

namespace Namespace2
{
  public class MyClass
  {
    public void Write()
    {
      //...
    }
  }
}
