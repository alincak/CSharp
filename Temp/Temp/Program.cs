using System;

namespace Temp
{
  class Program
  {
    static void Main(string[] args)
    {
      Product product = new Product();
      Modify(in product);


      int i = 42;
      Method(i);
      Method(in i);
    }

    public static void Modify(in Product product)
    {
      //product = new Product();
      product.ProductId = 101;
      product.ProductName = "Laptop";
      product.Price = 60000;
      Console.WriteLine($"Id: {product.ProductId} Name: {product.ProductName} Price: {product.Price}");
    }

    static void Method(int argument)
    {
      //...
    }

    static void Method(in int argument)
    {
      //argument = 10;
    }
  }

  class Product
  {
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
  }

}
