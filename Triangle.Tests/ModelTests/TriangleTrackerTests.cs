using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void EvaluateTriangle_ReturnsThreeIntegersWhenPassedThreeIntegers_SideOneSideTwoSideThree()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual(true, testTriangleTracker.EvaluateTriangle());
      // Assert.AreEqual((3, 4, 6), EvaluateTriangle(3, 4, 6));
    }
  }
}