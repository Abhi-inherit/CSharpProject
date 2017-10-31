using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_connect
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionString1 obj = new ConnectionString1();
            string address, state, city;
            int zipcode;

            int count;

            Console.Write("Enter the number of address needed to be stored");

            count = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.Write("Enter address:");
                address = Console.ReadLine();

                Console.Write("Enter state:");
                state = Console.ReadLine();

                Console.Write("Enter city:");
                city = Console.ReadLine();

                Console.Write("Enter ZipCode");
                zipcode = Convert.ToInt32(Console.ReadLine());


                int objStatus = obj.ExecuteQuery("insert into Tbl_Branches values ('" + address + "', '"+state+"','"+city+"','"+zipcode+"')");

                if(objStatus > 0)
                {
                    Console.WriteLine("Inserted data succesfully");
                    Console.ReadLine();
                }
            }

            Console.Clear();

            DataTable dt = new DataTable();
            dt = obj.TableData("select Address,State,City,Zipcode from Tbl_Branches");
            if (dt.Rows.Count > 0)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    string Address = dt.Rows[j].ItemArray[0].ToString();
                    Console.WriteLine(Address);

                    string State = dt.Rows[j].ItemArray[1].ToString();
                    Console.WriteLine(State);

                    string City = dt.Rows[j].ItemArray[2].ToString();
                    Console.WriteLine(City);

                    string ZipCode = dt.Rows[j].ItemArray[3].ToString();
                    Console.WriteLine(ZipCode);
                }
            }
            Console.ReadLine();
        }
    }
}
