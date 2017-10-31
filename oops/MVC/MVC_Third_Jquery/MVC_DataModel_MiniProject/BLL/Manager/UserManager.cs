using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Models;

namespace BLL.Manager
{
    public class UserManager
    {
        db_mvctourismEntities db = new db_mvctourismEntities();

        public List<entyPlace> getallPlaces()
        {
            var places = db.sp_GetallPlaces();

            List<entyPlace> lstplaces = new List<entyPlace>();
            var placeslist = from obj in places select new entyPlace { Id = obj.Id, Places = obj.Places, Discription = obj.Discription, Fk_Districtid = obj.Fk_Districtid, Image = obj.Image };
            lstplaces = placeslist.ToList();
            return lstplaces;
        }

        public string saveUser(entyuser obj)
        {
            return db.sp_UserReg(obj.Name, obj.Address, obj.Email, obj.Phone, obj.Image, obj.User_name, obj.Password, obj.Created_date, obj.Updated_date, "w").FirstOrDefault();

        }

    }
}
