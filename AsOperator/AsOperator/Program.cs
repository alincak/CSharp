using System;

namespace AsOperator
{
  class Program
  {
    static void Main(string[] args)
    {
      var _derived = new Derived();

      var _base = _derived as Base;
      if (_base != null)
      {
        //...
      }

      Base _base2 = null;
      if (_derived is Base)
      {
        _base2 = (Base)_derived;
        if (_base2 != null)
        {
          //...
        }
      }

    }
  }

  public class Base { }

  public class Derived : Base { }
}
