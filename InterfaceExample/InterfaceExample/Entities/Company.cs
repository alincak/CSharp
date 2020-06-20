namespace InterfaceExample.Entities
{
  class Company : Entity, IContactInfo
  {
    public string TradingName { get; set; }
    public string TaxNo { get; set; }
    public override string DisplayName
    {
      get
      {
        return string.Format("{0} ({1})", Name, TradingName);
      }
    }
    public ContactInfo[] ContactInfos { get; set; }
  }
}
