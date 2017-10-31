using System;
using System.Collections.Generic;

namespace MVC_PartialView.Models
{
    public partial class tbl_People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public Nullable<int> Place { get; set; }
        public string Status { get; set; }
        public virtual tbl_Place tbl_Place { get; set; }
    }
}
