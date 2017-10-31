using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_connect
{
    class ConnectionString1
    {
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Real_Estate;Integrated Security=True");

        public ConnectionString1()
        {
            con.Open();
        }

        public int ExecuteQuery(string query)
        {
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            return cmd.ExecuteNonQuery();
        }

        public DataTable TableData(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
