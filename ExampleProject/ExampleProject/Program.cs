using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 3);
            Console.WriteLine("The result is " + result );
        }
    }
}
