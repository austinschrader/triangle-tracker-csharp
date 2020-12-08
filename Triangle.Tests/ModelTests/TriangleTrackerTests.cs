using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void ClassifyTriangle_ChecksForIsosceles_StringIsosceles()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual("isosceles", testTriangleTracker.ClassifyTriangle(5, 5, 3));
    }

    [TestMethod]
    public void ClassifyTriangle_ChecksForEquilateral_StringEquilateral()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual("equilateral", testTriangleTracker.ClassifyTriangle(4, 4, 4));
    }

    [TestMethod]
    public void ClassifyTriangle_ChecksForScalene_StringScalene()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual("scalene", testTriangleTracker.ClassifyTriangle(5, 4, 3));
    }

    [TestMethod]
    public void IsTriangle_ChecksIfTriangle_True()
    {
      TriangleTracker testTriangleTracker = new TriangleTracker();
      Assert.AreEqual(true, testTriangleTracker.IsTriangle(4, 4, 4));
    }

  }
}