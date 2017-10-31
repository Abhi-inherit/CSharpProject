using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExecuteScalar
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Real_Estate;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from Tbl_Branches", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            Console.WriteLine("The total count of entries in the table:" + count);
            Console.ReadLine();
        }
    }
}
