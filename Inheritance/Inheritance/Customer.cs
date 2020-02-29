namespace Inheritance
{
  class Customer : Entity //Türemiş sınıf (derived class)
  {
    public string Name { get; set; }
    public Company Company { get; set; }
    public string Position { get; set; }
  }
}
