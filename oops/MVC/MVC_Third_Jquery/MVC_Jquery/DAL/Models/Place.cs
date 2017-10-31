using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Place
    {
        public Place()
        {
            this.Registrations = new List<Registration>();
        }

        public int Id { get; set; }
        public string Places { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
