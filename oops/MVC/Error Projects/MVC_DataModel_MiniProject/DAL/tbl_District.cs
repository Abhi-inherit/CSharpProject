//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_District
    {
        public tbl_District()
        {
            this.tbl_Hotel = new HashSet<tbl_Hotel>();
            this.tbl_Tax = new HashSet<tbl_Tax>();
            this.tbl_TouristPlaces = new HashSet<tbl_TouristPlaces>();
        }
    
        public int Id { get; set; }
        public string District_name { get; set; }
        public System.DateTime Created_date { get; set; }
        public System.DateTime Updated_date { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<tbl_Hotel> tbl_Hotel { get; set; }
        public virtual ICollection<tbl_Tax> tbl_Tax { get; set; }
        public virtual ICollection<tbl_TouristPlaces> tbl_TouristPlaces { get; set; }
    }
}