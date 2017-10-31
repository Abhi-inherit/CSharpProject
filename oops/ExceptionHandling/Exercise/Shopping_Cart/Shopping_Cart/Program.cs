using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Program
    {
        static void Main()
        {    
                  Item_to_buy obj = new Item_to_buy();
                  ShoppingCart Order = new ShoppingCart();
                  int i = 0;
                  int z = 0;
             Found:
                  try { 
                            do
                            {
                                 
                                  i++;
                                  Console.WriteLine("CARRFOUR SHOPPING CART");
                                  Console.WriteLine("");
                                  obj.ShowItem();
                                  var total = obj.itemToCart.Sum(v => v.Value);
                                  if (total>0 && z == 0)
                                    {
                                        goto Found1;
                                    }
                                  if (z == 1)
                                  {
                                      z = 0;
                                      goto Found3;
                                  }
            Found3:
                                  Console.Write("Enter the product name u want to buy: ");
                                  string x = Console.ReadLine();
                                  Console.Write("Enter the quantity of {0} needed to buy in kg or liter: ",x);
                                  int qty = Convert.ToInt32(Console.ReadLine());
                                  if (qty.GetType() == typeof(int))
                                  {
                                      if (obj.itemToCart.ContainsKey(x))
                                      {
                                          Console.WriteLine("");
                                          Console.WriteLine(" 1) Already you have entered the commodity {0}.\n 2) Please DELETE the commodity to make changes.\n 3) Press ENTER for continuing shopping.", x);
                                          Console.ReadLine();
                                          Console.Clear();
                                          goto Found;
                                      }
                                      obj.AddItemToCart(x, qty);
                                      if (obj.AddItemToCart(x,qty) == false) 
                                      {
                                          Console.Clear();
                                          Console.WriteLine("");
                                          Console.WriteLine(" 1) You have entered a wrong selection of commodity.\n 2) Please add a comnmodity from our list (Product NAME and NUMERALS are key sensitive).\n 3) Press ENTER for continuing shopping.");
                                          Console.ReadLine();
                                          Console.Clear();
                                          goto Found;
                                      }
                                      Console.WriteLine("");
                                  }
                                  else
                                  {
                                      Console.WriteLine("You have entered a wrong input.");
                                      goto Found;
                                  }
            Found1:
                                  obj.DisplayItemToShop();
                                  int choice = Options();
                                  if (choice == 1)
                                  {
                                      Console.Clear();
                                       z  = 1;
                                      continue;
                                  }
                                  else if (choice == 2)
                                  {
                                      Console.Clear();
                                      obj.DisplayItemToShop();
                                      Console.Write("Please enter the product name u want to delete from cart: ");
                                      string deleteItem = Console.ReadLine();
                                      if (obj.itemToCart.ContainsKey(deleteItem))
                                      {
                                          obj.DeleteItem(deleteItem);
                                      }
                                      else
                                      {
                                          Console.WriteLine("");
                                          Console.WriteLine(" 1) You have enetred a wrong entry.\n 2) Press ENTER for continuing shopping.");
                                          Console.ReadLine();
                                          Console.Clear();
                                          goto Found;
                                      }

                                  }
                                  else if (choice == 3)
                                  {
                                      obj.MakeOrder();
                                  }
                                  else if (choice == -1)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine(" 1) You have enetred a wrong entry.\n 2) Press ENTER for continuing shopping.");
                                        Console.ReadLine();
                                        goto Found;
                                    }
                                  else
                                  {
                                      Console.ReadLine();
                                  }

                            }
                            while (i < 1000000); 
                                  Console.ReadLine();
                                  }

                  catch (Exception) 
                  {
                      Console.WriteLine();
                      Console.WriteLine(" 1) You have entered a wrong format input.\n 2) Please note WORDS and NUMBERS are key sensitive.\n 3) Press ENTER for continuing shopping.");
                      Console.ReadLine();
                      Console.Clear();
                      goto Found;
                  }

        }
 
        static int Options()
        {
           try {  
           
            Console.Write(" Press 1 for ADDING more item to cart.\n Press 2 for DELETING the items from cart.\n Press 3 for PLACING an order\n :");
            int choice = Convert.ToInt32(Console.ReadLine());
             return choice;
           
           }
            catch(Exception)
            {
                return -1;
            }
          
        } 
    }
}
