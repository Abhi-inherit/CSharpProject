using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise
{
    class MyDerived: AbstractClass
    {
        public override void MyMethod()
        {
            x++;
            y++;
        }
        public override int Getx
        {
            get { return x + 10; }
        }

        public override int GetY
        {
            get { return y + 10; }
        }
    }
}
