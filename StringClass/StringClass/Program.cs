using System;

namespace StringClass
{
  class Program
  {
    static void Main(string[] args)
    {
      var text = " Belirtilen bir karakter konumunda başlayan ve dizenin sonunda sona eren bir dizeden bir alt dize çıkarmak için... ";
      var sample = new Sample(text);

      Console.WriteLine("GenerateText");
      var t = Sample.GenerateText('a', 10);
      Console.WriteLine(t);

      Console.WriteLine();
      Console.WriteLine("Display");
      sample.Display();

      Console.WriteLine();
      Console.WriteLine("Remove");
      sample.Remove(2, 5);

      Console.WriteLine();
      Console.WriteLine("IndexOf");
      sample.IndexOf('t');

      Console.WriteLine();
      Console.WriteLine("Replace");
      sample.Replace("bir", "iki");

      Console.WriteLine();
      Console.WriteLine("DisplayCharacters");
      sample.DisplayCharacters(7, 8);

      Console.WriteLine();
      Console.WriteLine("DisplayCharacters");
      sample.DisplayCharacters();

      Console.ReadKey();
    }
  }
}
