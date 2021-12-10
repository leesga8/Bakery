namespace Bakery.Models
{
  public class Bread
  {
    public int total {get; set; }

    public int BreadCost(int number)
    {
      total =0;
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