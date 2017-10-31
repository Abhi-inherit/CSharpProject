using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVC4_Listbox.Models
{
    public class ent_Registration
    {
        [ScaffoldColumn(false)] // ScaffoldColumn - Allows hiding fields from editor forms
        public int Id { get; set; }

        [Required]  // Required - Indicates that the property is a required field
        [DisplayName("Registration name")] // DisplayName - Defines the text to be used on form fields and validation messages
        public string Name { get; set; }

        [Required]
        [ValidateDateRange] // Custom validation
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "An address is required")]
        [DisplayFormat(ConvertEmptyStringToNull = false)] // DisplayFormat - Specifies how data fields are displayed and formatted.
        [StringLength(160, MinimumLength = 2)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Place is required")]
        public int PlaceID { get; set; }

        public string PlaceName { get; set; }


        public class ValidateDateRange : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                DateTime dt = Convert.ToDateTime(value);
                // your validation logic
                if (dt >= Convert.ToDateTime("01/10/2008") && dt <= Convert.ToDateTime("03/23/2017"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Date is not in given range.");
                }
            }
        }
    }
}