using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleProperties
{
    class Circle
    {
        private double _radius;

        public double Radius
        {
            get
            {
                if (_radius < 0)
                    return 0.00;
                else
                    return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public double Diameter
        {
            get
            {
                return Radius * 2;
            }
        }

        public double Circumference
        {
            get
            {
                return Diameter * Math.PI;
            }
        }

        public double Area
        {
            get
            {
                return Radius * Radius * Math.PI;
            }
        }

    }
    class Sphere : Circle
    {
    }
}
