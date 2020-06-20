using System;

namespace ConversionOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      var d = new Digit(10);

      byte number = d;
      Console.WriteLine(number);

      Console.WriteLine();

      Digit digit = (Digit)number;
      Console.WriteLine(digit);
    }
  }

  public struct Digit
  {
    private readonly byte digit;

    public Digit(byte digit)
    {
      if (digit > 9)
      {
        throw new ArgumentOutOfRangeException(nameof(digit), "Rakam dokuzdan büyük olamaz.");
      }

      this.digit = digit;
    }

    //Örnektir. Konuyla alakası yok.
    public static byte operator +(Digit s)
    {
      return 0;
    }

    //implicit
    public static implicit operator byte(Digit d)
    {
      return d.digit;
    }

    //explicit
    public static explicit operator Digit(byte b)
    {
      return new Digit(b);
    }
  }
}
