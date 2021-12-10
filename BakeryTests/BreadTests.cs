using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadCost_GetCostofOneLoaf_Num()
    {
      //Arrange
      Bread newBread = new Bread();
      //Act
      Assert.AreEqual(5, newBread.BreadCost(1));
      //Assert
    }
        [TestMethod]
    public void BreadCost_GetCostofThreeLoavesOneFree_Num()
    {
      //Arrange
      Bread newBread = new Bread();
      //Act
      Assert.AreEqual(10, newBread.BreadCost(3));
      //Assert
    }
  }
}
