using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList IPLTeams = new ArrayList();

            IPLTeams.Add("Chennai kings");
            IPLTeams.Add("Mumbai Indians");
            IPLTeams.Add("Rajastan Royals");
            IPLTeams.Add("Knight Riders");

            foreach (string item in IPLTeams)
            {
                Console.Write(item + "\n");
            } 
            Console.ReadLine();
        }
    }
}
