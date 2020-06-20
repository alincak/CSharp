using InterfaceExample.Entities;
using System;

namespace InterfaceExample
{
  class Program
  {
    static void Main(string[] args)
    {
      WriteEntity(MyClass.GetCompany);
      WriteEntity(MyClass.GetIndividual);

      Console.WriteLine();

      WriteIDisplayName(MyClass.GetCompany);
      WriteIDisplayName(MyClass.GetIndividual);

      Console.WriteLine();

      WriteContactInfos(MyClass.GetCompany);
      WriteContactInfos(MyClass.GetIndividual);

      Console.WriteLine();

      WriteIContactInfos(MyClass.GetCompany);
      WriteIContactInfos(MyClass.GetIndividual);
    }

    public static void WriteEntity(Entity entity)
    {
      Console.WriteLine(entity.DisplayName);
    }

    public static void WriteIDisplayName(IDisplayName entity)
    {
      Console.WriteLine(entity.DisplayName);
    }

    public static void WriteContactInfos(Company company)
    {
      Console.WriteLine("Company");
      foreach (var item in company.ContactInfos)
      {
        if (!string.IsNullOrEmpty(item.Phone))
        {
          Console.WriteLine($"Telefon: { item.Phone }");
        }
        else
        {
          Console.WriteLine($"Adres: { item.Address }");
        }
      }
      Console.WriteLine();
    }

    public static void WriteContactInfos(Individual individual)
    {
      Console.WriteLine("Individual");
      foreach (var item in individual.ContactInfos)
      {
        if (!string.IsNullOrEmpty(item.Phone))
        {
          Console.WriteLine($"Telefon: { item.Phone }");
        }
        else
        {
          Console.WriteLine($"Adres: { item.Address }");
        }
      }
      Console.WriteLine();
    }

    public static void WriteIContactInfos(IContactInfo entity)
    {
      Console.WriteLine("IContactInfo");
      foreach (var item in entity.ContactInfos)
      {
        if (!string.IsNullOrEmpty(item.Phone))
        {
          Console.WriteLine($"Telefon: { item.Phone }");
        }
        else
        {
          Console.WriteLine($"Adres: { item.Address }");
        }
      }
      Console.WriteLine();
    }
  }

  static class MyClass
  {
    public static Individual GetIndividual
    {
      get
      {
        var infos = new ContactInfo[]
          {
            new ContactInfo { Id = 3, Phone = "5111111111" },
            new ContactInfo { Id = 4, Address = "İstanbul" }
          };

        return new Individual
        {
          Id = 1,
          Name = "Fatih",
          LastName = "Han",
          IdentityNumber = "111111111111",
          ContactInfos = infos
        };
      }
    }

    public static Company GetCompany
    {
      get 
      {
        var infos = new ContactInfo[]
          {
            new ContactInfo { Id = 5, Phone = "52222222222" },
            new ContactInfo { Id = 6, Address = "Bursa" }
          };

        return new Company
        {
          Id = 2,
          Name = "Stwok Teknoloji",
          TradingName = "Stwok Teknoloji Anonim Şirketi",
          TaxNo = "1111111111111",
          ContactInfos = infos
        };
      }
    }
  }
}
