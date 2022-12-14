using System.Transactions;

namespace LineComparisonUsingOops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");
            LineComparison lineComparison=new LineComparison();
            //Console.WriteLine("Enter the coordinates of End Points of First Line");
            //double length1 = lineComparison.Length();
            //Console.WriteLine("Enter the coordinates of End Points of Second Line");
            //double length2 = lineComparison.Length();
            //lineComparison.Comparsion(length1, length2);
            int x1 = lineComparison.Length();
            int x2 = lineComparison.Length();
            int x3 = lineComparison.Length();
            int x4 = lineComparison.Length();
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
        }
    }
}