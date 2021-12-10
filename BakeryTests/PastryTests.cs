using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }    
    
    [TestMethod]
    public void PastryCost_GetCostofTotalPastry_Num()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(9, newPastry.PastryCost(5));
    }

    [TestMethod]
    public void PastryCost_GetCostofOnePastry_Num()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(2, newPastry.PastryCost(1));
    }
  }
}