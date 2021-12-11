using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Project
{
  public class Program
  {
    public static int TotalCost(int b, int p)
    {
      int total = b + p;
      return total; 
    }
    public static void Main()
    {
      Console.WriteLine("---------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery! We sell fresh whole loaves of Bread and Pastries.");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Our prices today: \nWhole Bread Loaves: $5\nPastries: $2");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Our specials today: \nBuy 2 Get 1 free Bread!\nBuy 2 Pastries get 3rd $1 off!");
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
      Console.WriteLine("Your total cost of is $"+ TotalCost(brad.BreadCost(numBread), pat.PastryCost(numPastry))+".\nThank you, have a nice day.");
      Console.WriteLine("---------------------------");
    }
  }
}