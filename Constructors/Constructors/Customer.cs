using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int id;
        public string name;
        public List<Order> Orders;
        //ctor + tab
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
            : this()
        {
            this.id = id;
        }

        public Customer(int id , string name)
            : this(id)
        {
            this.id = id;
            this.name = name;
        }
    }
}
