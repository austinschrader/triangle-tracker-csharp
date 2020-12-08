namespace Triangle
{
  public class TriangleTracker
  {
    public string ClassifyTriangle(int side1, int side2, int side3)
    {
      if (side1 == side2 && side2 == side3)
      {
        return "equilateral";
      }
      else if (side1 == side2 || side2 == side3 || side1 == side3)
      {
        return "isosceles";
      }
      else
      {
        return "scalene";
      }
    }

    public bool IsTriangle(int side1, int side2, int side3)
    {
      if (side1 <= (side2 + side3) && side2 <= (side3 + side1) && side3 <= (side1 + side2))
      {
        return true;
      }
      return false;
    }

  }
}