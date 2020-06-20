using System;
using System.Collections.Generic;

namespace RefKeywords
{
  class Program
  {
    static void Main(string[] args)
    {
      var bc = new BookCollection();
      bc.ListBooks();

      var index = -1;
      ref var book = ref bc.GetBookByTitle("Call of the Wild, The", ref index);
      if (book != null)
      {
        book = new Book { Title = "Republic, The", Author = "Plato" };
      }

      Console.WriteLine();
      bc.ListBooks();
    }
  }

  public class Book
  { 
    public string Author { get; set; }
    public string Title { get; set; }
  }

  public class BookCollection
  {
    private Book[] books =
    {
      new Book { Title = "Call of the Wild, The", Author = "Jack London" },
      new Book { Title = "Tale of Two Cities, A", Author = "Charles Dickens" }
    };

    private Book nobook = null;

    public ref Book GetBookByTitle(string title, ref int index)
    {
      for (int i = 0; i < books.Length; i++)
      {
        if (title == books[i].Title)
        {
          index = i;
          return ref books[i];
        }
      }

      return ref nobook;
    }

    public void ListBooks()
    {
      foreach (var book in books)
      {
        Console.WriteLine($"{ book.Title }, By { book.Author }");
      }
      Console.WriteLine();
    }
  }
}
