using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonUsingOops
{
    internal class LineComparison
    {
        public double Length()
        {
            Console.WriteLine("Enter End points");
            Console.WriteLine("Enter x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Length of Line is: " + length);
            return length;
        }
        public void Comparsion(double x, double y)
        {
            if (x == y)
            {
                Console.WriteLine("Both Line are equal in Length");
            }
            else if (x > y)
            {
                Console.WriteLine("Line1 is Longer");
            }
            else
            {
                Console.WriteLine("Line2 is Longer");
            }
        }
    }
}
