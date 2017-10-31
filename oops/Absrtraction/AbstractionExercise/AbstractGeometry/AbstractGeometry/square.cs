using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    class square : Description
    {
        public override string Name
        {
            get { return "Square"; }
        }
        public override string Describe()
            {
                string introuction = base.Describe()+
                    "\nA square is a quatrilaterl that has four equal sides and four right angles";

                return introuction;
            }
        
    }
}
