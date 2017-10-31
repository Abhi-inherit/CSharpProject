using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVC_FourthMethod.Models
{
    public class ent_Registration
    {
        [ScaffoldColumn(false)] // ScaffoldColumn - Allows hiding fields from editor forms
        public int studentId { get; set; }

        [Required]  // Required - Indicates that the property is a required field
        [DisplayName("Registration name")] // DisplayName - Defines the text to be used on form fields and validation messages
        public string name { get; set; }

        [Required]  // Required - Indicates that the property is a required field
        [DisplayName("E Mail")] // DisplayName - Defines the text to be used on form fields and validation messages
        public string eMail { get; set; }

        [Required]  // Required - Indicates that the property is a required field
        [DisplayName("Password")] // DisplayName - Defines the text to be used on form fields and validation messages
        public string password { get; set; }

        [Required]  // Required - Indicates that the property is a required field
        [DisplayName("Course")] // DisplayName - Defines the text to be used on form fields and validation messages
        public string course { get; set; }

        [Required]  // Required - Indicates that the property is a required field
        [DisplayName("District")] // DisplayName - Defines the text to be used on form fields and validation messages
        public string district { get; set; }

        [Required]  // Required - Indicates that the property is a required field
        [DisplayName("Gender")] // DisplayName - Defines the text to be used on form fields and validation messages
        public string gender { get; set; }
    }
}