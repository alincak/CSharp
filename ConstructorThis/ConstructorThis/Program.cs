using System;

namespace ConstructorThis
{
  class Program
  {
    static void Main(string[] args)
    {
      var b = new B();
      b.Write();
      
      Console.WriteLine();

      var b1 = new B(101);
      b1.Write();

      Console.WriteLine();

      var b2 = new B(200, 250);
      b2.Write();
    }
  }

  class A
  {
    private Random m_random { get; set; }
    protected int Value { get { return m_random.Next(m_minValue, m_maxValue); } }

    private int m_minValue { get; set; }
    private int m_maxValue { get; set; }

    public A(int minValue, int maxValue)
    {
      m_minValue = minValue;
      m_maxValue = maxValue;

      m_random = new Random();
    }
  }

  class B : A
  {
    public B() : this(0, 100)
    { 
    }

    public B(int minValue) : this(minValue, minValue * 10)
    {
    }

    public B(int minValue, int maxValue) : base(minValue, maxValue)
    { 
    }

    public void Write()
    {
      Console.WriteLine($"Rasgele değeri: { Value }");
    }
  }
}
