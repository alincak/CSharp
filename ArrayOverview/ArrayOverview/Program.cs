namespace ArrayOverview
{
  class Program
  {
    static void Main(string[] args)
    {
      var _ =
        @"1 - Bir dizi tek boyutlu, çok boyutlu veya dizi dizileri olabilir

          2 - Boyut sayısı ve her boyutun uzunluğu, dizi örneği oluşturulduğunda oluşturulur. 
          Bu değerler, kullanım ömrü boyunca değiştirilemez.

          3 - Sayısal dizi öğelerinin varsayılan değerleri sıfır olarak ve başvuru öğeleri null olarak ayarlanır

          4 - Dizi öğeleri, bir dizi türü de dahil olmak üzere herhangi bir türde olabilir

          5 - Dizi türleri, Arraysoyut temel türünden türetilmiş başvuru türleridir. 
              Bu tür IEnumerable ve IEnumerable<T> uyguladığından, tüm dizilerde foreach yineleme kullanabilirsiniz
        ";

      //1
      int _s = 5;
      var _1 = new int[5];
      var _2 = new int[5, 5];
      var _3 = new int[5][];

      //2
      var _4 = new int[4];

      //3
      int[] _5;

      //4
      var _6 = new string[4];

      //5
      foreach (int item in _1) //ilk değeri: _1[0]
      {
        //...
      }
    }
  }
}
