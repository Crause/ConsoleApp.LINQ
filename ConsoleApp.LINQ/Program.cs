using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.LINQ
{
  class Program
  {
    static Random rnd = new Random();
    static void Main(string[] args)
    {
      #region 1
      //var collection = new List<int>();
      //for (int i = 0; i < 10; i++)
      //{
      //  collection.Add(i);
      //}

      //var result = from item in collection
      //          where item < 5
      //          select item;
      ////IEnumerable//
      //var result2 = collection.Where(item => item < 5);

      //foreach (var item in result)
      //{
      //  Console.WriteLine($"{item} ");
      //}
      //Console.WriteLine();
      //foreach (var item in result2)
      //{
      //  Console.WriteLine($"{item} ");
      //}
      //Console.ReadLine();
      #endregion

      #region 2

      var products = new List<Product>();
      for (int i = 0; i < 10; i++)
      {
        var product = new Product()
        {
          Name = "Product" + i,
          Energy = rnd.Next(197, 203)
        };
        products.Add(product);
      }

      var result = from item in products
                   where item.Energy < 200
                   select item;

      var result2 = products.Where(item => item.Energy < 200);

      foreach (var item in result)
      {
        Console.WriteLine(item + " ");
      }
      Console.WriteLine();
      foreach (var item in result2)
      {
        Console.WriteLine(item + " ");
      }

      var selectCollection = products.Select(product => product.Energy);
      foreach (var item in selectCollection)
      {
        Console.WriteLine(item + " ");
      }
      Console.WriteLine();

      var orderbyCollection = products.OrderBy(product => product.Energy)
                                      .ThenByDescending(product => product.Name);
      foreach (var item in orderbyCollection)
      {
        Console.WriteLine(item + " ");
      }

      var groupbyCollection = products.GroupBy(product => product.Energy);
      foreach (var group in groupbyCollection)
      {
        Console.WriteLine($"Key: {group.Key}");
        foreach (var item in group)
        {
          Console.WriteLine($"\t{item}");
        }
        Console.WriteLine();
      }


      products.Reverse();
      foreach (var item in products)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine(products.All(item => item.Energy == 200));
      Console.WriteLine(products.Any(item => item.Energy == 200));

      var prod = new Product();
      Console.WriteLine(products.Contains(prod));

      var array = new int[] {1, 2, 3, 4 };
      var array2 = new int[] { 3, 4, 5, 6 };

      var union = array.Union(array2);
      foreach (var item in union)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();

      var intersect = array.Intersect(array2);
      foreach (var item in intersect)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();

      var except1 = array.Except(array2);
      foreach (var item in except1)
      {
        Console.WriteLine(item);
      }
      Console.WriteLine();

      var except2 = array2.Except(array);
      foreach (var item in except2)
      {
        Console.WriteLine(item);
      }

      var sum = array.Sum();
      var min = products.Min(p => p.Energy);
      var max = products.Max(p => p.Energy);
      var aggregate = array.Aggregate((x, y) => x * y);

      var sum2 = array.Skip(1).Take(2).Sum();

      var first = array.First();
      var last = array.LastOrDefault();
      var single = products.Single(product => product.Energy == 199);
      var elementAt = products.ElementAt(5);


      Console.ReadLine();
      #endregion


    }
  }
}
