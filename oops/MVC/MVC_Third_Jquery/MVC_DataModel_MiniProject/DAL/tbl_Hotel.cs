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
    
    public partial class tbl_Hotel
    {
        public tbl_Hotel()
        {
            this.tbl_Booking = new HashSet<tbl_Booking>();
        }
    
        public int Id { get; set; }
        public int fk_Districtid { get; set; }
        public int fk_Placeid { get; set; }
        public int fk_Roomid { get; set; }
        public string Hotel_Name { get; set; }
        public string Image { get; set; }
        public string Discription { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Hotel_Type { get; set; }
        public string Price { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public System.DateTime Created_date { get; set; }
        public System.DateTime Updated_date { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<tbl_Booking> tbl_Booking { get; set; }
        public virtual tbl_District tbl_District { get; set; }
        public virtual tbl_Room tbl_Room { get; set; }
        public virtual tbl_TouristPlaces tbl_TouristPlaces { get; set; }
    }
}
