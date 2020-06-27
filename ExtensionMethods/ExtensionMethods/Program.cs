using System;
using ExtensionMethods.Extension;

namespace ExtensionMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      var _string = "Hello Extension Methods";

      var wordCount = _string.Split(' ').Length;
      Console.WriteLine($"Kelime sayısı: { wordCount }");

      Console.WriteLine();

      var wordCount2 = WordCount(_string);
      Console.WriteLine($"Kelime sayısı2: { wordCount2 }");

      Console.WriteLine();

      var wordCount3 = _string.WordCount();
      Console.WriteLine($"Kelime sayısı3: { wordCount3 }");
    }

    static int WordCount(string str)
    {
      return str.Split(' ').Length;
    }
  }

}
