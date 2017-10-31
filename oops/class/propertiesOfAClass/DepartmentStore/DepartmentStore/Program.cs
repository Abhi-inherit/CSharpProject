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
            OrderProcessing odp = new OrderProcessing();
            odp.ProcessOrder();
            Console.Clear();

            odp.DisplayReceipt();

            Console.ReadKey();
        }
    }
}
