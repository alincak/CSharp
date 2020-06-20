namespace InterfaceExample.Entities
{
  class Individual : Entity, IContactInfo
  {
    public string LastName { get; set; }
    public string IdentityNumber { get; set; }
    public override string DisplayName
    {
      get
      {
        return string.Format("{0} {1}", Name, LastName);
      }
    }
    public ContactInfo[] ContactInfos { get; set; }
  }
}
