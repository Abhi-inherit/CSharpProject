using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    class Rectangle : Description
    {
        public override string Name
        {
            get { return "Rectangle"; }
        }
        public override string Describe()
        {
            return base.Describe() + "\nA rectangle contains four angles in different angles";
        }
    }
}
