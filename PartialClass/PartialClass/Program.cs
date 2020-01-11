using System;

namespace PartialClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}

namespace SampleNested
{
  partial class Container
  {
    public void Test() { }
  }

  partial class Container
  {
    public void Test2() { }
  }
}

namespace SampleNested2
{
  class Container
  {
    partial class Nested 
    {
      void Test() { }
    }

    partial class Nested
    {
      void Test2() { }
    }
  }
}

namespace SampleNested3
{
  partial class Container
  {
    partial class Nested { }
  }

  partial class Container
  {
    partial class Nested { }
  }
}
