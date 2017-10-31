using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Customer
    {
        public Dictionary<string, int> customers { get; set; }

        public Customer()
        {
            customers = new Dictionary<string, int>();
            customers.Add("abhi@gmail.com", 1);
            customers.Add("praji@gmail.com", 2);
            customers.Add("riji@gmail.com", 3);
            customers.Add("rohit@gmail.com", 4);
            customers.Add("sasa@gmail.com", 5);
        }

        public void CheckCustomer(string mailId)
        {
            if (customers.ContainsKey(mailId))
            {
                Console.Clear();
                Console.WriteLine(" Thanks for shopping with us.\n Products will be delivered in 24 hour.\n Call center - 800 9642");
                Console.ReadLine();
            }
            else
            {
                int x = 1;
                RegisterCustomerName(x);
            }
        }

        public void RegisterCustomerName(int x)
        {
            if (x == 1)
            {
                x = 0;
                Console.WriteLine("Customer is not registerd. Please enter your vaid E mail ID for registering");
                Console.Write("");
                string newMailId = Console.ReadLine();
                customers.Add(newMailId,x);
            }
            else
            {
                Console.WriteLine("Please enter your vaid E mail ID for registering");
                Console.Write("");
                string newMailId = Console.ReadLine();
                customers.Add(newMailId, x);
                CheckCustomer(newMailId);
            }
        }
    }
}
