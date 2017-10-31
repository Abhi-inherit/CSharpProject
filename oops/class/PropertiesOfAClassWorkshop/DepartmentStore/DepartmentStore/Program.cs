using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStore
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderProcessing op = new OrderProcessing();
            op.processOrder();
            Console.Clear();
            op.DisplayReceipt();
            Console.ReadKey();
        }
    }
}
