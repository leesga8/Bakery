using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost(int num)
    {
      if (num % 3 == 0)
      {
        return (num / 3)*5;
      }
      else
      {
        return (num / 3)*5 + (num % 3)*2;
      }
    }
  }
}