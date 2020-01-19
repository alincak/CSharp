using System;

namespace EnumClass
{
  class Program
  {
    static void Main(string[] args)
    {
      EnumTest.WriteDays();

      var user = new User();
      user.Name = "Mustafa";
      user.LastName = "Test";
      user.Scopes = User.UserScopes.FileRead | User.UserScopes.MailReadWrite;

      Console.WriteLine($"Kişi: { user.Name } { user.LastName }, Yetkileri: { user.Scopes }");

      Console.WriteLine($"Dosya okumaya yetkisi: { user.CheckScopes(User.UserScopes.FileRead) }");
      Console.WriteLine($"Dosyayı değiştirme yetkisi: { user.CheckScopes(User.UserScopes.FileWrite) }");
    }
  }

  public static class EnumTest
  {
    enum Days
    {
      Saturday,
      Sunday,
      Monday,
      Tuesday,
      Wednesday,
      Thursday,
      Friday
    }

    enum Colors
    {
      Red = 100,
      Green = 150,
      Blue = 152,
      Yellow
    }

    public static void WriteDays()
    {
      var weekdays = typeof(Days);
      var names = Enum.GetNames(weekdays);

      for (var i = 0; i < names.Length; i++)
      {
        var name = names[i];
        Console.WriteLine("{0, -11}= {1}", name, Enum.Format(weekdays, Enum.Parse(weekdays, name), "d"));
      }
    }
  }

  public class User
  {
    [Flags]
    public enum UserScopes
    { 
      None = 0,
      MailRead = 1,
      MailWrite = 2,
      FileRead = 4,
      FileWrite = 8,
      MailReadWrite = MailRead | MailWrite,
      FileReadWrite = FileRead | FileWrite
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public UserScopes Scopes { get; set; }

    public string CheckScopes(UserScopes scopes)
    {
      var hasScope = Scopes.HasFlag(scopes);
      return hasScope ? "Var" : "Yok";
    }
  }

}
