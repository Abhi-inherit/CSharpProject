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
    
    public partial class tbl_Room
    {
        public tbl_Room()
        {
            this.tbl_Booking = new HashSet<tbl_Booking>();
            this.tbl_Hotel = new HashSet<tbl_Hotel>();
            this.tbl_Tax = new HashSet<tbl_Tax>();
        }
    
        public int Id { get; set; }
        public string Room_Type { get; set; }
        public System.DateTime Created_Date { get; set; }
        public System.DateTime Updated_Date { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<tbl_Booking> tbl_Booking { get; set; }
        public virtual ICollection<tbl_Hotel> tbl_Hotel { get; set; }
        public virtual ICollection<tbl_Tax> tbl_Tax { get; set; }
    }
}
