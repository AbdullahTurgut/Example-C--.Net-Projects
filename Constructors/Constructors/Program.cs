using System;


namespace Constructors
{
    class Program
    {
        //ctrl + tab for the short key changing c# files
        static void Main(string[] args)
        {
            var customer = new Customer(1,"Abdullah");
            Console.WriteLine(customer.id);
            Console.WriteLine(customer.name);
        }
    }
}
