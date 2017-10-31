using System;

//namespace example_enum
//{
//    class Program
//    {
//        public enum DayofWeek
//        {
//            Sunday = 0, Monday, Tuesday = 56, Wednesday, Thursday, Friday, Saturday
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Sunday, DayofWeek.Sunday);
//            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Monday, DayofWeek.Monday);
//            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Tuesday, DayofWeek.Tuesday);
//            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Wednesday, DayofWeek.Wednesday);
//            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Thursday, DayofWeek.Thursday);
//            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Friday, DayofWeek.Friday);
//            Console.WriteLine("Day of week {0} {1}", (int)DayofWeek.Saturday, DayofWeek.Saturday);
//            Console.ReadLine();
//        }
//    }
//}


namespace BAsicProgramming
{
    public enum DayofWeek
    {
        f15,mig22,rtr5,raptor1,sukoi25,mig17,reeder15
    }
    class Management
    {

        static void Main(string[] args)
        {
            Console.WriteLine("American backbone {0}", DayofWeek.f15);
            Console.WriteLine("Russian Storm {0}",  DayofWeek.mig22);
            Console.WriteLine("Indian Hawk {0} {1}", (int)DayofWeek.rtr5, DayofWeek.rtr5);
            Console.WriteLine("American spy{0} {1}", (int)DayofWeek.raptor1, DayofWeek.raptor1);
            Console.WriteLine("Russian Stealth {0} {1}", (int)DayofWeek.sukoi25, DayofWeek.sukoi25);
            Console.WriteLine("Russian Pride {0} {1}", (int)DayofWeek.mig17, DayofWeek.mig17);
            Console.WriteLine("Indian air Mighty {0} {1}", (int)DayofWeek.reeder15, DayofWeek.reeder15);
            Console.ReadLine();
        }
    }

}
