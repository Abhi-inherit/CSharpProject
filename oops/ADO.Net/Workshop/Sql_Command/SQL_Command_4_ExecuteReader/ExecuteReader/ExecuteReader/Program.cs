using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExecuteReader
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Real_Estate;Integrated Security=True");
            con.Open();

            SqlDataReader rdr = null;

            SqlCommand cmd = new SqlCommand("select Address,State,City,Zipcode from Tbl_Branches", con);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[0]);
                Console.WriteLine(rdr[1]);
                Console.WriteLine(rdr[2]);
                Console.WriteLine(rdr[3]);
            }

            Console.ReadLine();
            rdr.Close();
            con.Close();
        }
    }
}
