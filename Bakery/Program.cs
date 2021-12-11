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
      Console.WriteLine("Please enter the number of bread loaves you'd like to order. Only whole loaves please: ");
      int numBread = int.Parse(Console.ReadLine());
      Console.WriteLine("---------------------------");
      Console.WriteLine("Please enter a the number of pastries you'd like to order. Only whole pastries please: ");
      int numPastry = int.Parse(Console.ReadLine());
      Console.WriteLine("---------------------------");
      Bread brad = new Bread();
      Console.WriteLine("Your total cost of Bread is $" + brad.BreadCost(numBread));
      Pastry pat = new Pastry();
      Console.WriteLine("Your total cost of Pastry is $" + pat.PastryCost(numPastry));
      Console.WriteLine("---------------------------");
      Console.WriteLine("Your total cost of is $"+ brad.BreadCost(numBread) + pat.PastryCost(numPastry));
    }
  }
}