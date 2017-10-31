using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StateManagement.Classes
{
    public class ProductDetails
    {
        public string name;
        public string duration;
        public string database;
        public string fee;
        public string topics;
        public string perDayHours;

        public ProductDetails(String Name, String Duration, String Database, String Fee, String Topics, String PerDayHour) 
        {
            name = Name;
            duration = Duration;
            database = Database;
            fee = Fee;
            topics = Topics;
            perDayHours = PerDayHour;
        }
    }
}