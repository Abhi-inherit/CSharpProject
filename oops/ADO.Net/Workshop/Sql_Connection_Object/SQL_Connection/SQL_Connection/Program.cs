using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Connection
{
    class Program
    {
        static void Main()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Real_Estate;Integrated Security=True");

            if (con.State == ConnectionState.Open)
            {
                Console.WriteLine("Connection state is :" + con.State);
                Console.ReadLine();
            }
            else
            {
                con.Open();
                Console.WriteLine("Connection state is :" + con.State);
                Console.ReadLine();
                Main();
            }

        }
    }
}
