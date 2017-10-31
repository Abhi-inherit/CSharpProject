using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_DataReader_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new  SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Real_Estate;Integrated Security=True");

            con.Open();

            SqlDataReader rdr = null;

            SqlCommand cmd = new SqlCommand("select Address,State from Tbl_Branches", con);
            rdr = cmd.ExecuteReader();
            Console.WriteLine("State                          Address");
            Console.WriteLine("-----                          -------");
            Console.WriteLine("-----                          -------");

            while(rdr.Read())
            {
                string State = (string)rdr["State"];
                string Address = (string)rdr["Address"];

                Console.Write("{0,-25}", State);
                Console.Write("{0,-25}", Address);

                Console.WriteLine();
           // Console.WriteLine(State+""+Address);
            }
                Console.ReadLine();
                con.Close();
        }
    }
}
