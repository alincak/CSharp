using System;

namespace GenericMethodsConstraints
{
  class Program
  {
    static void Main(string[] args)
    {
      GenericHelper.Method1<int>();
      GenericHelper.Method2<A>();
      GenericHelper.Method3<A>();
      GenericHelper.Method4<B>();
      GenericHelper.Method5<B>();
      GenericHelper.Method6<B, A>();
    }
  }

  interface IField { }
  class A 
  {
    public A()
    { 
    }

    public A(int a)
    { 
      
    }
  }

  class B : A, IField { }

  class GenericHelper
  {
    public static void Method1<T>() where T : struct
    { 
      //...
    }

    public static void Method2<T>() where T : class
    { 
      //...
    }

    public static void Method3<T>() where T : new()
    { 
      //...
    }

    public static void Method4<T>() where T : A
    { 
      //...
    }

    public static void Method5<T>() where T : IField
    { 
      //...
    }

    public static void Method6<T, T1>() where T : T1 
    {
      //...
    } 

  }
}
