using System;

namespace GenericInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      var myClass = new MyClass<string>("Generic Field");
      Console.WriteLine("FieldValue: {0}, Field.GetType(): {1}", myClass.GetField(), myClass.Field.GetType());
    }
  }

  interface IField<T>
  { 
    T Field { get; set; }
    T GetField();
    void GetField(string field);
  }

  class MyClass<T> : IField<T>
  { 
    public T Field { get; set; }

    public MyClass(T _field)
    {
      Field = _field;
    }

    public T GetField()
    {
      return Field;
    }

    public void GetField(string field)
    {
      //...
    }
  }
}
