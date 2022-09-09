using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Rendering;
//using NBILicenseProjectMVC.Enums;

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
        [Display(Name ="List of Valid ID's")]
        public string ValidId { get; set; }

        [Required]
        [Display(Name = "Applicant's Picture")]
        public string ApplicantPicture { get; set; }

        [DataType(DataType.Text)]
        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [DataType(DataType.MultilineText)]
        [Required]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [DataType(DataType.MultilineText)]
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
        [Display(Name ="Civil Status")]
        public string CivilStatus { get; set; }

        [Display(Name = "Highest Educational Attainment")]
        public string EducationalAttainment { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Landline Number")]
        public int? LandlineNumber { get; set; }

        [DataType(DataType.Text)]
        //[RegularExpression(@"^(?:[0-9]{11})?$")]
        [Display(Name = "Mobile Number")]
        public int? MobileNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", ErrorMessage = "Invalid Email Address.")]
        public string EmailAddress { get; set; }

        public string Complexion { get; set; }

        public string Peculiarities { get; set; }

        [DataType(DataType.Text)]
        public string Religion { get; set; }

        [Range(1, 300, ErrorMessage = "Height should be between 1 cm and 300 cm")]
        [Display(Name ="Height (cm)")]
        public decimal? Height { get; set; }

        [Range(1, 100, ErrorMessage = "Height should be between 1 kg and 100 kg")]
        [Display(Name = "Weight (kg)")]
        public decimal? Weight { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name ="Name of Husband or Wife")]
        public string HusbandOrWifeName { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Father's Name")]
        public string FatherName { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Father's Birth Place")]
        public string FatherBirthplace { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Mother's Name")]
        public string MotherName { get; set; }

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

    







}
