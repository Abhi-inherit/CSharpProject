using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    public class Item_to_buy
    {
        public Dictionary<string, int> itemList { get; set; }
        public Dictionary<string, int> itemToCart { get; set; }

        public Item_to_buy()
        {
            itemToCart = new Dictionary<string, int>();

            itemList = new Dictionary<string,int>();
            itemList.Add("Sugar", 20);
            itemList.Add("Rice", 40);
            itemList.Add("Tea", 30);
            itemList.Add("Coffee", 25);
            itemList.Add("Salt", 5);
            itemList.Add("Milk", 20);
        }

        public void ShowItem()
        {
            AddItem();
        }


        public void AddItem()
        {
            var total = itemToCart.Sum(v => v.Value);
            if (total > 0)
            {
                Console.Clear();
                DisplayItemToShop();
            }

            int x = 1;
            foreach (KeyValuePair<string, int> Item in itemList)
            {
                if (x == 6)
                {
                    Console.WriteLine("Enter {0} for-> {2}, Rate per liter-{1}\n", x++, Item.Value, Item.Key);

                }
                else
                {
                    Console.WriteLine("Enter {0} for-> {2}, Rate per kg-{1}\n", x++, Item.Value, Item.Key);
                }
            } 
        }

        public bool AddItemToCart(string x,int qty)
        {
            try {
                if (itemList.ContainsKey(x))
                {
                    int y = itemList[x];
                    int price = y * qty;
                    itemToCart.Add(x, price);
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                ShowItem();
            }
            return true;
        }

        public void DeleteItem(string item)
        {
            if (itemToCart.ContainsKey(item))
            {
                itemToCart.Remove(item);
                Console.Clear();
                Console.WriteLine("Commodity {0} removed from your cart", item);
                Console.WriteLine("");
                Console.WriteLine("COMMODITIES ON YOUR CART.");
                DisplayItemToShop();
            }
        }

        public void DisplayItemToShop()
        {
            foreach (KeyValuePair<string, int> item in itemToCart)
            {
                Console.WriteLine("Cammodity - {1}, Rate -{0}", item.Value,item.Key);
            }

            var total = itemToCart.Sum(v => v.Value);
            Console.WriteLine("TOTAL AMOUNT {0}.", total);
            Console.WriteLine("");

        }

        public bool MakeOrder()
        {
            Console.Clear();
            DisplayItemToShop();
            Console.Write(" Press 1 for CONFORMING the order.\n Press 2 for CANCELlING the order.\n :");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x == 1)
            {
                Customer cs = new Customer();
                Console.Write(" Enter your registered mail id if you r registered.\n Press 2 for registering new customer.");
                string mailId = Console.ReadLine();
                if (mailId == "2")
                {
                    int y = 0;
                    cs.RegisterCustomerName(y);
                }
                else
                {
                    cs.CheckCustomer(mailId);
                }
            }
            else if (x == 2)
            { 
                Console.Clear();
                itemToCart.Clear();
                return true;
            }
            else
            { 
            
            }
           // Console.Clear();
            return true;
        }

    }
}
