using System;

namespace Inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      var company = CreateCompany();
      var customer = CreateCustomer(company);
    }

    public static Company CreateCompany()
    {
      var company = new Company
      {
        Id = 1,
        Name = "TurkBel",
        TaxNo = "123456789",
        TaxOffice = "Esenler"
      };

      return company;
    }

    public static Customer CreateCustomer(Company company = null)
    {
      var customer = new Customer
      {
        Id = 2,
        Name = "Mustafa",
        Position = "Yazılımcı",
        Company = company
      };

      return customer;
    }
  }
}
