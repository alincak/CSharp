using System;
using System.Collections.Generic;
using System.Text;

namespace StringClass
{
  class Sample
  {
    private string _text;

    public Sample(string text)
    {
      _text = string.IsNullOrEmpty(text)
        ? string.Empty
        : text.Trim();
    }

    private bool IsNullOrEmpty()
    {
      return string.IsNullOrEmpty(_text);
    }

    public static string GenerateText(char c, int count)
    {
      return new string(c, count);
    }

    public void Display()
    {
      Console.WriteLine(_text);
    }

    public void Remove(int startIndex, int count)
    {
      Console.WriteLine(string.Format("Eski metin: {0}", _text));
      var newText = _text.Remove(startIndex, count);
      Console.WriteLine(string.Format("Yeni metin: {0}", newText));
    }

    public void IndexOf(char value)
    {
      var index = _text.IndexOf(value);
      Console.WriteLine(string.Format("'{0}' Index: {1}", value, index));
    }

    public void Replace(string oldValue, string newValue)
    {
      if (IsNullOrEmpty())
      {
        Console.WriteLine("Text is null or empty.");
        return;
      }

      Console.WriteLine(string.Format("Eski metin: {0}", _text));
      var newText = _text.Replace(oldValue, newValue);
      Console.WriteLine(string.Format("Yeni metin: {0}", newText));
    }

    public void DisplayCharacters(int startIndex, int length)
    {
      var newText = _text.Substring(startIndex, length);
      DisplayCharacters(newText);
    }

    public void DisplayCharacters()
    {
      DisplayCharacters(_text);
    }

    private void DisplayCharacters(string text)
    {
      for (int i = 0; i < text.Length; i++)
      {
        Console.WriteLine(text[i]);
      }
    }
  }
}
