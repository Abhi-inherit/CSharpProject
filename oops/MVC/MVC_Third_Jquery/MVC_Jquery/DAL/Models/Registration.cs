using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Nullable<int> PlaceID { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public virtual Place Place { get; set; }
    }
}
