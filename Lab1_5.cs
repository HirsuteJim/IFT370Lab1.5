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
