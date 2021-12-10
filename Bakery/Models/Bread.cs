namespace Bakery.Models
{
  public class Bread
  {
      int total = 0;
    public int BreadCost(int number)
    {
      for (int i = 1; i <= number; i++)
      {
        if (i % 3 == 0)
        {
          total += 0;
        } else {
          total += 5;
        }
      }
      return total;
    }
  }
}