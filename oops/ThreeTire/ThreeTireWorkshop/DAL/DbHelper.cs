using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DbHelper
    {
        public SqlCommand cmd;
        public SqlConnection con;

        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Student_Registeration;Integrated Security=True");

            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            return con;
        }

        public DataTable GetDistrictName() 
        {
             SqlDataAdapter adpt = new SqlDataAdapter("select district_name from District",GetConnection());
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public int Check(string x,string y)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StudentDetails WHERE eMail= '" + x + "' AND password= '" + y + "'", GetConnection());
            int Count = Convert.ToInt32(cmd.ExecuteScalar());
            return Count;
        }

        public string ExecuteProcedure(SortedList list,string query)
        {
            try 
            {
                SqlCommand cmd = new SqlCommand(query,GetConnection());
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                if(!(list.Count==0))
                {
                    string[] mKeys = new string[list.Count];
                    list.Keys.CopyTo(mKeys,0);
                    int i = 0;
                    for (i = 1; i <= list.Count; i++ )
                        {
                            cmd.Parameters.Add(new SqlParameter("@"+mKeys[i-1],list[mKeys[i-1]]));

                        }
                }
                string x;
                return x = cmd.ExecuteScalar().ToString();
            }
            catch(Exception)
            {
                return "-1";
            }
            finally 
            {
                if(GetConnection().State==ConnectionState.Open)
                {
                    GetConnection().Close();
                }
            }
        }
        

    }
}

