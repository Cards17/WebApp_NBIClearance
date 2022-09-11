
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Rendering;
using NBILicenseProjectMVC.Enums;
using System.Text.RegularExpressions;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NBILicenseProjectMVC.Models
{
    public partial class Applicant
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Branch Name")]
        public string BranchName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Valid ID")]
        public string ValidId { get; set; }

        [Required]
        [Display(Name = "Applicant's Photo")]
        public string ApplicantPicture { get; set; }

        [DataType(DataType.Text)]
        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [DataType(DataType.Text)]
        [Required]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [DataType(DataType.Text)]
        [Required]
        [Display(Name = "Middle Name")]
        public string Middlename { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Civil Status")]
        public string CivilStatus { get; set; }

        [Required]
        [Display(Name = "Highest Educational Attainment")]
        public string EducationalAttainment { get; set; }

        [Required(ErrorMessage = "You must enter a phone number")]
        [Display(Name = "Landline Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Not a valid phone number")]
        public string LandlineNumber { get; set; }

        [Required(ErrorMessage = "You must enter a mobile number")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^(?:[0-9]{11})?$" , ErrorMessage = "Invalid mobile number and/or format")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", ErrorMessage = "Invalid Email Address.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "You must choose your complexion.")]
        public string Complexion { get; set; }

        [Required(ErrorMessage = "You must enter your peculiarities, if none write 'N/A'.")]
        [DataType(DataType.MultilineText)]
        public string Peculiarities { get; set; }

        [Required(ErrorMessage = "You must enter you religious affiliation.")]
        [DataType(DataType.Text)]
        public string Religion { get; set; }

        [Required(ErrorMessage = "You must choose a value.")]
        [Range(1, 300, ErrorMessage = "Height should be between 1 cm and 300 cm")]
        [Display(Name = "Height (cm)")]
        public decimal? Height { get; set; }

        [Required(ErrorMessage = "You must choose a value.")]
        [Range(1, 200, ErrorMessage = "Height should be between 1 kg and 200 kg")]
        [Display(Name = "Weight (kg)")]
        public decimal? Weight { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "The Address must be at least 1 character")]
        [MaxLength(100, ErrorMessage = "The Address cannot be more than 100 characters")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Name of Husband or Wife")]
        public string HusbandOrWifeName { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "The Address must be at least 1 character")]
        [MaxLength(100, ErrorMessage = "The Address cannot be more than 100 characters")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Father's Name")]
        public string FatherName { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "The Address must be at least 5 characters")]
        [MaxLength(100, ErrorMessage = "The Address cannot be more than 100 characters")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Father's Birth Place")]
        public string FatherBirthplace { get; set; }

        [Required]
        [MinLength(1, ErrorMessage = "The Address must be at least 1 character")]
        [MaxLength(100, ErrorMessage = "The Address cannot be more than 100 characters")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Mother's Name")]
        public string MotherName { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "The Address must be at least 5 characters")]
        [MaxLength(100, ErrorMessage = "The Address cannot be more than 100 characters")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Mother's Birth Place")]
        public string MotherBirthplace { get; set; }
    }

    public static class EnumExtensions
    {

        public static string GetDisplayName<T>(this T enumValue) where T : IComparable, IFormattable, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("Argument not of type Enum");
            }

            DisplayAttribute displayAttribute = enumValue.GetType().GetMember(enumValue.ToString()).First().GetCustomAttribute<DisplayAttribute>();

            return displayAttribute?.GetName() ?? enumValue.ToString();
        }
    }

    public class SortFilter
    {
        public string sortBy { get; set; } //Column name
        public string order { get; set; } //asc or desc
    }
}