using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
    public abstract class Description
    {
        public abstract string Name { get; }

        public virtual string Describe() 
        {
            return "A quatriladeral is a geometric figure that has a four side and four angles.";
        }
    }
}
