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
    
    public partial class sp_GetallPlaces_Result
    {
        public int Id { get; set; }
        public int Fk_Districtid { get; set; }
        public string Places { get; set; }
        public string Discription { get; set; }
        public string Nearesr_Place { get; set; }
        public string Image { get; set; }
        public System.DateTime Created_date { get; set; }
        public System.DateTime Updated_date { get; set; }
        public string Status { get; set; }
    }
}
