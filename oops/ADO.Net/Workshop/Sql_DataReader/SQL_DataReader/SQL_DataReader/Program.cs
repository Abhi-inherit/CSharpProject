﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_DataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-I5Q4TKGM\\SQLEXPRESS;Initial Catalog=Real_Estate;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("select Address from Tbl_Branches",con);
            SqlDataReader sdr = null;
            sdr = cmd.ExecuteReader();
            Console.WriteLine("The inserted address is as listed below:");

            while(sdr.Read())
            {
                Console.WriteLine(sdr[0]);
            }
            Console.ReadLine();
        }
    }
}