using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStore
{
    class OrderProcessing
    {
        private int qty;
        private ShoppingItem itm;


        public int Quantity
        {
            get { return qty; }
            set
            {
                if (qty <= 0)
                    qty = 0;
                else
                    qty = value;
            }
        }

        public ShoppingItem SaleItem
        {
            get { return itm; }
            set
            {
                if (itm == null)
                {
                    itm.ItemNumber = 0;
                    itm.Category = ItemCategory.Unspecified;
                    itm.Name = "Unknown";
                    itm.Size = "0";
                    itm.UnitPrice = 0.00M;
                }
                else
                    itm = value;
            }
        }
        public OrderProcessing()
        {
            itm = new ShoppingItem();
        }
        public void ProcessOrder()
        {
            int category;

            Console.WriteLine("/-/Fun Department Store/-/");
            Console.WriteLine("Enter the following pieces of");
            Console.WriteLine("information about the sale item");
            Console.Write("Item #:     ");
            itm.ItemNumber = long.Parse(Console.ReadLine());
            
            Console.WriteLine("Store Items Categories");
            Console.WriteLine("\t1. Women");
            Console.WriteLine("\t2. Men");
            Console.WriteLine("\t3. Girls");
            Console.WriteLine("\t4. Boys");
            Console.WriteLine("\t5. Babies");
            Console.Write("Enter the Category: ");
            category = int.Parse(Console.ReadLine());
            if (category == 1)
                itm.Category = ItemCategory.Women;
            else if (category == 2)
                itm.Category = ItemCategory.Men;
            else if (category == 3)
                itm.Category = ItemCategory.Girls;
            else if (category == 4)
                itm.Category = ItemCategory.Boys;
            else if (category == 5)
                itm.Category = ItemCategory.Babies;
            else
                itm.Category = ItemCategory.Unspecified;
            
            Console.Write("Item Name:  ");
            itm.Name = Console.ReadLine();
            Console.Write("Item Size (Enter 0 if unknown):  ");
            itm.Size = Console.ReadLine();
            Console.Write("Unit Price: ");
            itm.UnitPrice = decimal.Parse(Console.ReadLine());
            Console.Write("How many samples of ");
            Console.Write(itm.Name);
            Console.Write(": ");
            qty = int.Parse(Console.ReadLine());
        }
        public void DisplayReceipt()
        {
            decimal totalPrice = itm.UnitPrice * Quantity;

            Console.WriteLine("\n================================");
            Console.WriteLine("/-/Fun Department Store/-/");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Item #:      {0}", itm.ItemNumber);
            Console.WriteLine("Category:    {0}", itm.Category);
            Console.WriteLine("Description: {0}", itm.Name);
            Console.WriteLine("Item Size:   {0}", itm.Size);
            Console.WriteLine("Unit Price:  {0:C}", itm.UnitPrice);
            Console.WriteLine("Quantity:    {0}", Quantity);
            Console.WriteLine("Total Price: {0:C}\n", totalPrice);
            Console.WriteLine("\n================================");
        }
    }
}
