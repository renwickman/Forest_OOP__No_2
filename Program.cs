using System;

namespace Forest_OOP__No_2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Forest.ForestsCreated);

      Forest f1 = new Forest("Pine", "Desert");
      Forest f2 = new Forest("Sycamore");

      Console.WriteLine(Forest.ForestsCreated);
    }
  }
}