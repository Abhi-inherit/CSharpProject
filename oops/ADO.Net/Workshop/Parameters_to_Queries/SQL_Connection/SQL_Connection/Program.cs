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
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Real_Estate;Integrated Security=True");

            con.Open();

            string address, state, city;
            int zipcode;

            int count;

            Console.Write("Enter total number of address needded to be inserted:");
            count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter address:");
                address = Console.ReadLine();

                Console.Write("Enter state:");
                state = Console.ReadLine();

                Console.Write("Enter city:");
                city = Console.ReadLine();

                Console.Write("Enter zipcode:");
                zipcode = Convert.ToInt32(Console.ReadLine());

                SqlCommand cmd = new SqlCommand("Brances_Insert",con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@address", address));
                cmd.Parameters.Add(new SqlParameter("@state", state));
                cmd.Parameters.Add(new SqlParameter("@city", city));
                cmd.Parameters.Add(new SqlParameter("@zipcode",zipcode));

                cmd.ExecuteNonQuery();
            }
        }
    }
}
