// // See https://aka.ms/new-console-template for more information
// using System;
// using System.Collections.Generic;
// using System.Text;
// using System.Linq;
// class Program
// {
//   static void Main(string[] args)
//   {
//     Console.WriteLine("\n================================================================================\n");

//     List<int> values = new List<int> { -1, -3, 0, 1, 3, 2, 9, -4 };

//     var filtered = values.FindAll(FunctionalMethods.IsPositive()); 

//     Console.WriteLine(string.Join(' ', filtered));

//     Console.WriteLine("\n================================================================================\n");
//     Console.WriteLine(FunctionalMethods.LoneSum()(1, 2, 3));
//     Console.WriteLine(FunctionalMethods.LoneSum()(3, 2, 3));
//     Console.WriteLine(FunctionalMethods.LoneSum()(3, 3, 3));
//     Console.WriteLine("\n================================================================================\n");
//   }
// };
