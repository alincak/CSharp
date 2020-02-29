using System;

namespace Inheritance
{
  class Entity //Taban sınıf (base class)
  {
    public int Id { get; set; }
    public DateTime EnteredDate { get { return DateTime.UtcNow; } }
    public DateTime ModifiedDate { get; set; }
  }
}
