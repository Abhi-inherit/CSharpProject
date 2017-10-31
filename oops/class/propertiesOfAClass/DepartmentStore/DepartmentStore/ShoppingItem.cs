using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStore
{
    public enum ItemCategory
    {
        Unspecified,
        Women,
        Men,
        Girls,
        Boys,
        Babies
    }
    public class ShoppingItem
    {
        private long itemNo;
        private ItemCategory cat;
        private string nm;
        private string sz;
        private decimal price;


        // A property for the stock number of an item
        public long ItemNumber
        {
            get
            {
                return itemNo;
            }

            set
            {
                itemNo = value;
            }
        }
        // A property for the category of item
        public ItemCategory Category
        {
            get
            {
                return cat;
            }

            set
            {
                cat = value;
            }
        }

        // A property for the name of an item
        public string Name
        {
            get
            {
                return nm;
            }

            set
            {
                if (nm == null)
                    nm = "Item no Description";
                else
                    nm = value;
            }
        }
        // A property for size of a merchandise
        public string Size
        {
            get
            {
                if (sz == "0")
                    return "Unknown Size or Fits All";
                else
                    return sz;
            }

            set
            {
                sz = value;
            }
        }
        // A property for the marked price of an item
        public decimal UnitPrice
        {
            get
            {
                return price;
            }

            set
            {
                if (price < 0)
                    price = 0.00M;
                else
                    price = value;
            }
        }

    }
}
