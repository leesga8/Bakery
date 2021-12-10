using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Project
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Please enter a whole number of bread loaves you'd like: ");
      int numBread = int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter a whole number of pastries you'd like: ");
      int numPastry = int.Parse(Console.ReadLine());
      Bread brad = new Bread();
      Console.WriteLine(brad.BreadCost(numBread));
      Pastry pat = new Pastry();
      Console.WriteLine(pat.PastryCost(numPastry));

    }
  }
}