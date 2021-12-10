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
      /*
      user will enter number of bread they want.
      buy 2 get 1 free
      userinput = 7
      for(i=1; i<userinput; i++)
      { if(i % 3 == 0)
      { total += 0}
      else if{i %3 !=0 }
        total += 5
        */
    }
  }
}