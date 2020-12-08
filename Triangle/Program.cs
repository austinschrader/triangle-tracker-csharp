using System;
using System.Collections.Generic;
using System.Threading;

namespace Triangle
{
  public class Program
  {

    static void Main()
    {
      Console.WriteLine("Please enter three numbers, one for each side of a triangle;");
      // Gather three numbers (ie. side lengths) from the user
      Console.WriteLine("The length you want for first triangle side:");
      string sideOne = Console.ReadLine();
      Console.WriteLine("The length you want for second triangle side:");
      string sideTwo = Console.ReadLine();
      Console.WriteLine("The length you want for third triangle side:");
      string sideThree = Console.ReadLine();

      // Show that the capture of side lengths worked
      Console.WriteLine("side one: " + sideOne + " side two: " + sideTwo + " side three: " + sideThree);
      Console.WriteLine("All three are pushed!");

      int side1 = int.Parse(sideOne);
      int side2 = int.Parse(sideTwo);
      int side3 = int.Parse(sideThree);

      Console.WriteLine(side1 + side2 + side3);
    }
  }
}
