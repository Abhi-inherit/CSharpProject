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
            var placeslist = from obj in places select new entyPlace { Id = obj.Id, Places = obj.Places, Fk_Districtid = obj.Fk_Districtid, Discription = obj.Discription, Image = obj.Image };
            lstplaces = placeslist.ToList();
            return lstplaces;
        }
    }
}
