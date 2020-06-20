namespace InterfaceExample.Entities
{
  class Entity : IDisplayName
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual string DisplayName { get { return Name; } }
  }
}
