using BLL.AdminManager;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AdminManager
{
    public class AdminLogin
    {
        DbHelper DB = new DbHelper();
        public BLL.AdminProperties.DistrictProperties Dis = new BLL.AdminProperties.DistrictProperties();
        public BLL.AdminProperties.StdRegEntry Sre = new BLL.AdminProperties.StdRegEntry();

        private SortedList s1 = new SortedList();

        public int Login_Check(string eMail,string password)
        {
          int x = DB.Check(eMail,password);

          return x;
        }

        public string DistrictInsert() 
        {
            s1.Clear();
            s1.Add("districtName", Dis.districtName);
            return DB.ExecuteProcedure(s1, "DistrictInsert");
        }

        public string DistrictUpdate()
        {
            s1.Clear();
            s1.Add("districtId",Dis.districtId);
            s1.Add("districtName",Dis.districtName);
            return DB.ExecuteProcedure(s1,"DistrictUpdate");
        }

        public string DistrictDelete()
        {
            s1.Clear();
            s1.Add("districtId",Dis.districtId);
            return DB.ExecuteProcedure(s1,"DistrictDelete");
        }

        public string stdDelete()
        {
            s1.Clear();
            s1.Add("studentId", Sre.stdId);
            return DB.ExecuteProcedure(s1, "StudentDelete");
        }

        public string StdRegInsert() 
        {
            s1.Clear();
            s1.Add("name", Sre.name);
            s1.Add("email", Sre.email);
            s1.Add("password", Sre.password);
            s1.Add("course", Sre.course);
            s1.Add("district", Sre.district);
            s1.Add("gender", Sre.gender);
            return DB.ExecuteProcedure(s1,"StudentRegister");
        }

        public string StdRegUpdate()
        {
            s1.Clear();
            s1.Add("studentId", Sre.stdId);
            s1.Add("name", Sre.name);
            s1.Add("email", Sre.email);
            s1.Add("password", Sre.password);
            s1.Add("course", Sre.course);
            s1.Add("district", Sre.district);
            s1.Add("gender", Sre.gender);
            return DB.ExecuteProcedure(s1, "StudentRegisterUpdate");
        }

        public DataTable DistrictNames() 
        {
           return DB.GetDistrictName();
        }

        
    }
}
