using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            //TryParse bool döndürür burda true/false olduğunu gördük
            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6, 7));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0} , {1})", point.X, point.Y);

                point.Move(120, 200);
                Console.WriteLine("Point is at ({0} , {1})", point.X, point.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }

        }
    }
}
