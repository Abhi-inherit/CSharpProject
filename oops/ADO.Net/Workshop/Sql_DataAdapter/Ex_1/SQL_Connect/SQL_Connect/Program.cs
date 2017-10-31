using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Connect
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Real_Estate;Integrated Security=True");
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select * from Tbl_Branches", con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            sda.Fill(ds,"Branches");
            dt = ds.Tables["Branches"];

            foreach(DataRow row in dt.Rows)
            {
                foreach(DataColumn col in dt.Columns)
                {
                    Console.WriteLine(row[col]);
                }
            }
            Console.ReadLine();
        }
    }
}
