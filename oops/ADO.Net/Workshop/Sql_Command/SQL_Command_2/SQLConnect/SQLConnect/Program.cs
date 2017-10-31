using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Real_Estate;Integrated Security=True");

            Console.Write("Enter Address:");
            string address = Convert.ToString(Console.ReadLine());
            Console.Write("Enter State:");
            string state = Convert.ToString(Console.ReadLine());
            Console.Write("Enter City:");
            string city = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Zip-Code:");
            string zip = Convert.ToString(Console.ReadLine());

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Tbl_Branches(Address,State,City,Zipcode) values ('" + address + "','" + state + "','" + city + "','" + zip + "')", con);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Data saved succesfully");
                Console.ReadLine();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
