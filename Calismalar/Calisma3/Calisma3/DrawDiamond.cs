using System;

namespace Calisma3
{
  //Kaynak: https://www.csharpstar.com/diamond-pattern-program-in-csharp/

  public class DrawDiamond
  {
    private char[] m_letter = new char[26]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };

    private string[] m_diamond = new string[52];
    private int m_letterNumber = 0;

    public void Draw()
    {
      m_letterNumber = FindLetterNumber();
      
      DrawFirstPart();
      DrawSecondPart();
    }

    private int FindLetterNumber()
    {
      //get the letter
      Console.WriteLine("A ve Z arasında bir karakter girin: ");
      char user_letter = Console.ReadKey().KeyChar;
      Console.WriteLine("");
      //search for letter number in the array letter
      for (int i = 0; i < m_letter.Length; i++)
      {
        if (m_letter[i] == user_letter)
        {
          return i;
        }
      }

      return 0;
    }

    private void DrawFirstPart()
    {
      //construct diamond 

      for (int i = 0; i <= m_letterNumber; i++)
      {
        //add initial spaces
        for (int j = 0; j < m_letterNumber - i; j++)
        {
          m_diamond[i] += " ";
        }

        //add letter (first time)
        m_diamond[i] += m_letter[i];

        //add space between letters
        if (m_letter[i] != 'A')
        {
          for (int j = 0; j < 2 * i - 1; j++)
          {
            m_diamond[i] += " ";
          }
          //add letter (second time)
          m_diamond[i] += m_letter[i];
        }
        // Draw the first part of the diamond as it's composing.
        Console.WriteLine(m_diamond[i]);
      }
    }

    private void DrawSecondPart()
    {
      for (int i = m_letterNumber - 1; i >= 0; i--)
      {
        // Draw the second part of the diamond
        // Writing the diamondArray in reverse order.
        Console.WriteLine(m_diamond[i]);
      }
    }

  }
}
