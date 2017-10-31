using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStore
{
    public enum itemCategory
    {
        Unspecified,
        Women,
        Men,
        Girls,
        Boys,
        Babies
    }

    class ShoppingItem
    {
        private itemCategory cat;
        private string nm;
        private string sz;
        private decimal price;

        public itemCategory Category
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
