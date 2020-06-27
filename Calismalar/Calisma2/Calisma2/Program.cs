using System;

namespace Calisma2
{
  class Program
  {
    static void Main(string[] args)
    {
      var user = new Users(10, "Soner", "soner123", "İstanbul");
      user.GetUserDetails(10);
      user.GetUserDetails("soner123");
    }
  }

  public class Users
  {
    private int m_id { get; set; }
    private string m_name { get; set; }
    private string m_username { get; set; }
    private string m_location { get; set; }

    public Users(int id, string name, string username, string location)
    {
      m_id = id;
      m_name = name;
      m_username = username;
      m_location = location;
    }

    public void GetUserDetails(int id)
    {
      Console.WriteLine("Id: {0}, Adı: {1}, Adresi: {2}", id, m_name, m_location);
    }

    public void GetUserDetails(string username)
    {
      Console.WriteLine("Kullanıcı adı: {0}, Adı: {1}, Adresi: {2}", username, m_name, m_location);
    }

  }

}
