namespace ExtensionMethods.Extension
{
  public static class Extension
  {
    public static int WordCount(this string str)
    {
      return str.Split(' ').Length;
    }
  }
}
