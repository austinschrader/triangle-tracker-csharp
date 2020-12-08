using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void EvaluateTriangle_ChecksForIsosceles_StringIsosceles()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual("isosceles", testTriangleTracker.EvaluateTriangle(5, 5, 3));
    }

    [TestMethod]
    public void EvaluateTriangle_ChecksForEquilateral_StringEquilateral()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual("equilateral", testTriangleTracker.EvaluateTriangle(4, 4, 4));
    }
  }
}