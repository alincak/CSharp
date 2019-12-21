using System;

namespace Operatorler
{
  class Program
  {
    static void Main(string[] args)
    {
      var a = 10;
      var b = 20;

      //Aritmetik */+-
      var x = a + b;
      x = a * b;
      x = a / b;
      x = a - b;


      //Karşılaştırma < > <= >= ==
      var y = a < b;
      y = a > b;
      y = a >= b;
      y = a <= b;
      y = a == b;

      //üç operandlı ?:
      var z = a == 10 
        ? a + 1 
        : a - 1;


      //Tek operandlı !
      var zz = !y;

      //iki operandlı || &&
      var yz = zz || y;
      yz = zz && y;

    }
  }
}