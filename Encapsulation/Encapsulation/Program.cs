using SampleDLL;

namespace Encapsulation
{
            //Public
            //Private
            //Protected
            //Internal
            //Protected internal
  
  class Program
  {
    static void Main(string[] args)
    {
      var sClass = new SampleClass();
      //sClass.m_text --- Hata
      

      var sBaseClass = new SampleBaseClass();
      //sBaseClass.BaseText ---- Hata

      var dllClass = new MyClassInternal();
      dllClass.Sample();
    }
  }

  class SampleClass : SampleBaseClass
  { 
    private string m_text { get; set; }

    public string Text
    {
      get { return m_text + BaseText; }
      set { m_text = value; }
    }
  }

  class SampleBaseClass
  { 
    protected string BaseText { get; set; }
  }
}
