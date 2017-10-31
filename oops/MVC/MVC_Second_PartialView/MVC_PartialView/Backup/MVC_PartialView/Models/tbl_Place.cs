using System;
using System.Collections.Generic;

namespace MVC_PartialView.Models
{
    public partial class tbl_Place
    {
        public tbl_Place()
        {
            this.tbl_People = new List<tbl_People>();
        }

        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string Status { get; set; }
        public virtual ICollection<tbl_People> tbl_People { get; set; }
    }
}
