using System;

namespace Namespaces
{
  class Program
  {
    static void Main(string[] args)
    {
      SampleA.B.SampleClass a;
      SampleA.A.SampleClass aa;

      SampleB.SampleClass b;
    }
  }
}

namespace SampleA.A
{
  class SampleClass
  { 
    
  }
}

namespace SampleA.B
{
  class SampleClass
  {

  }
}

namespace SampleB
{
  class SampleClass
  { 
    
  }
}