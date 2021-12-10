namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost(int number)
    {
      return number*2;
    }
    /*

    1 pastry is $2
    3 pastry is $5

    if(num%3==0)
    { 
    (num/3)5
    }else{
      Math.floor((num/3))5 + (num % 3)2
    }

    1: 2      7: 12      13: 22 
    2: 4      8: 14      14: 24
    3: 5      9: 15      15: 25
             
    4: 7      10: 17      16: 27
    5: 9      11: 19      17: 29
    6: 10     12: 20      18: 30
    */
  }
}