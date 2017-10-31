using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStore
{
    class OrderProcessing
    {
        private ShoppingItem itm;
        private int qty;

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


        public OrderProcessing()
        {
            itm = new ShoppingItem();
        }

        public void processOrder() 
        {

            int category;

            Console.WriteLine("Carrfour online shopping\r");
            Console.WriteLine("Enter the details of product.\r");
            Console.WriteLine("Select the category");
            Console.WriteLine("\t1. Women");
            Console.WriteLine("\t2. Men");
            Console.WriteLine("\t3. Girls");
            Console.WriteLine("\t4. Boys");
            Console.WriteLine("\t5. Babies");
            Console.Write("Enter the Category: ");
            category = int.Parse(Console.ReadLine());
            if (category == 1)
                itm.Category = itemCategory.Women;
            else if (category == 2)
                itm.Category = itemCategory.Men;
            else if (category == 3)
                itm.Category = itemCategory.Girls;
            else if (category == 4)
                itm.Category = itemCategory.Boys;
            else if (category == 5)
                itm.Category = itemCategory.Babies;
            else
                itm.Category = itemCategory.Unspecified;

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
            //Console.ReadLine(); 
        }
        public void DisplayReceipt()
        {
            decimal totalPrice = itm.UnitPrice * Quantity;
            Console.WriteLine("\n==============================");
            Console.WriteLine("Carffour online shopping");
            Console.WriteLine("--------------------------------");
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
