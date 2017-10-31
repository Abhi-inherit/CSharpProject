using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise
{
    abstract class AbstractClass
    {
        protected int x = 100;
        protected int y = 150;

        public abstract void MyMethod();

        public abstract int Getx
        {
            get;
        }

        public abstract int GetY
        {
            get;
        }
    }
}
