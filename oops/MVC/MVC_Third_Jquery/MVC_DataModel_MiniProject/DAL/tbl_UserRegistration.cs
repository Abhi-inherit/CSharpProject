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
    
    public partial class tbl_UserRegistration
    {
        public tbl_UserRegistration()
        {
            this.tbl_Booking = new HashSet<tbl_Booking>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        public System.DateTime Created_date { get; set; }
        public System.DateTime Updated_date { get; set; }
        public string status { get; set; }
    
        public virtual ICollection<tbl_Booking> tbl_Booking { get; set; }
    }
}
