using System;
using System.Collections.Generic;
using System.Text;

class FunctionalMethods
{
    public static Func<int, int, int, int> LoneSum()
    {
		Func<int, int, int, int> toReturn = (a, b, c) =>
        {
          if (a == b && b == c) return 0;
          if (a == b) return c;
          if (a == c) return b;
          if (b == c) return a;
          return a + b + c;
        };
		return toReturn;
    }

    public static Predicate<int> IsPositive() 
    {
        return (x) => x > 0;
    }
}

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("\n================================================================================\n");

    List<int> values = new List<int> { -1, -3, 0, 1, 3, 2, 9, -4 };

    var filtered = values.FindAll(FunctionalMethods.IsPositive()); 

    Console.WriteLine(string.Join(' ', filtered));

    Console.WriteLine("\n================================================================================\n");
    Console.WriteLine(FunctionalMethods.LoneSum()(1, 2, 3));
    Console.WriteLine(FunctionalMethods.LoneSum()(3, 2, 3));
    Console.WriteLine(FunctionalMethods.LoneSum()(3, 3, 3));
    Console.WriteLine("\n================================================================================\n");
  }
};

