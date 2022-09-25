using System;

namespace AreaOfShapesHW
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Choose a shape:");
			Console.WriteLine("1) Triangle");
			Console.WriteLine("2) Quadrilateral");
			Console.WriteLine("3) Circle");
			Console.Write("\r\nSelect a number as option.");
			int inputOption = int.Parse(Console.ReadLine());

			switch (inputOption)
			{
				case 1:
					int a, b, c, smallestSide, secondSmallest, longestSide, smallestSide2, secondSmallest2, longestSide2;
					double semiPerimeter, areaOfTriangle;
					Console.WriteLine("Enter 3 sizes:");
					a = int.Parse(Console.ReadLine());
					b = int.Parse(Console.ReadLine());
					c = int.Parse(Console.ReadLine());
					smallestSide = Math.Min(Math.Min(a, b), c);
					longestSide = Math.Max(Math.Max(a, b), c);
					secondSmallest = (a + b + c) - (longestSide - smallestSide);
					semiPerimeter = (a + b + c) / 2;
					areaOfTriangle = Math.Sqrt((semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c)));
					smallestSide2 = smallestSide * smallestSide;
					secondSmallest2 = secondSmallest * secondSmallest;
					longestSide2 = longestSide * longestSide;

					Console.WriteLine("The area of the triangle is: " + " " + areaOfTriangle);

					if (smallestSide2 + secondSmallest2 > longestSide2)
					{
						Console.WriteLine("Acute Triangle");

					}
					else if (smallestSide2 + secondSmallest2 == longestSide2)
					{
						Console.WriteLine("Right Triangle");
					}
					else
					{
						Console.WriteLine("Obstuse Triangle");
					}
					break;
				case 2:
					int e, f, g, h, height;
					Console.WriteLine("Enter 4 sizes:");
					e = int.Parse(Console.ReadLine());
					f = int.Parse(Console.ReadLine());
					g = int.Parse(Console.ReadLine());
					h = int.Parse(Console.ReadLine());

					if (e == f && f == g && g == h)

					{
						Console.WriteLine("Square");
						Console.WriteLine("Area: " + (e * e));
					}
					else if (e == g && f == h & f != e || e == f && g == h && e != h)

					{
						Console.WriteLine("Rectangle");
						Console.WriteLine("Area: " + (e * f));
					}
					else
					{
						Console.WriteLine("Trapezoid");
						Console.WriteLine("Enter height:");
						height = int.Parse(Console.ReadLine());
						Console.WriteLine("Area : " + ((e + f) / 2 * height));
					}
					break;


				case 3:
					double area;
					const double pi = 3.14;
					Console.WriteLine("Please enter radius:");
					int radius = int.Parse(Console.ReadLine());
					area = pi * (radius * radius);

					if (area > 100)
					{
						Console.WriteLine("Big Circle");
						Console.WriteLine("The area is: " + area);
					}
					else if (area <= 100)
					{
						Console.WriteLine("Small Circle");
						Console.WriteLine("The area is: " + area);
					}
					break;

			}
		}
	}
}
