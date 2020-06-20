using System;

namespace GenericTypes
{
  class Program
  {
    static void Main(string[] args)
    {
      var generic = new Generic<string, int>();
      generic.Field = "Strings";
      generic.Field2 = 10;

      Console.WriteLine("Generic.Field: {0}", generic.Field);
      Console.WriteLine("Generic.Field.GetType(): {0}", generic.Field.GetType().FullName);

      Console.WriteLine();

      Console.WriteLine("Generic.Field2: {0}", generic.Field2);
      Console.WriteLine("Generic.Field2.GetType(): {0}", generic.Field2.GetType().FullName);
    }
  }

  public class Generic<T, T1>
  { 
    public T Field { get; set; }
    public T1 Field2 { get; set; }
  }
}
