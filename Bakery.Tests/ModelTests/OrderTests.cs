using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadAmount_ReturnsAmount_Int()

    {
      int GetAmount = 2;
      Bread newBread = new Bread(GetAmount);
      int result = newBread.Amount;
      Assert.AreEqual(GetAmount, result);
    }

    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Bread()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

        [TestMethod]
    public void GetPastryAmount_ReturnsAmount_Int()

    {
      int GetAmount = 2;
      Pastry newPastry = new Pastry(GetAmount);
      int result = newPastry.Amount;
      Assert.AreEqual(GetAmount, result);
    }

    [TestMethod]
    public void BreadOrderCost_ReturnsTotalForZeroLoaves_Int()
    {
      Bread newBread = new Bread(5);
      int breadCount = 0;
      int breadCost = 0;
      Assert.AreEqual(breadCost, newBread.BreadOrderCost(breadCount));
    }

    [TestMethod]
    public void BreadOrderCost_ReturnsTotalForTwoLoaves_Int()
    {
      Bread newBread = new Bread(5);
      int breadCount = 2;
      int breadCost = 10;
      Assert.AreEqual(breadCost, newBread.BreadOrderCost(breadCount));
    }

    [TestMethod]
    public void BreadOrderCost_ReturnsTotalForThreeLoaves_Int()
    {
      Bread newBread = new Bread(5);
      int breadCount = 3;
      int breadCost = 10;
      Assert.AreEqual(breadCost, newBread.BreadOrderCost(breadCount));
    }

        [TestMethod]
    public void BreadOrderCost_ReturnsTotalForSixLoaves_Int()
    {
      Bread newBread = new Bread(5);
      int breadCount = 6;
      int breadCost = 20;
      Assert.AreEqual(breadCost, newBread.BreadOrderCost(breadCount));
    }
  }
}