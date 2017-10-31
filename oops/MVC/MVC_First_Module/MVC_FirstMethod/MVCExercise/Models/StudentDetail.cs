using System;
using System.Collections.Generic;

namespace MVCExercise.Models
{
    public partial class StudentDetail
    {
        public int studentId { get; set; }
        public string name { get; set; }
        public string eMail { get; set; }
        public string password { get; set; }
        public string course { get; set; }
        public string district { get; set; }
        public string gender { get; set; }
    }
}
