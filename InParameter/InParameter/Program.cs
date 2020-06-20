using System;

namespace InParameter
{
  class Program
  {
    static void Main(string[] args)
    {
      var product = new Product();
      Modify(product);


      var i = 42;
      Method(i);
      Method(in i);
    }

    static void Modify(in Product product)
    {
      //product = new Product();
      product.Id = 1;
      product.Name = "Laptop";
      product.Price = 3000;

      Console.WriteLine($"Id: { product.Id }, Name: { product.Name }, Price: { product.Price }");
    }

    static void Method(int argument) //Method int
    { 
      //...
    }

    static void Method(in int argument) //Method in int
    {
      //argument = 10;
    }

  }

  class Product
  { 
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}
