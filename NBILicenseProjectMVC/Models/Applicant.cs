using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }
        

        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public string EducationalAttainment { get; set; }
        public int? LandlineNumber { get; set; }
        public int? MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Complexion { get; set; }
        public string Peculiarities { get; set; }
        public string Religion { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string HusbandOrWifeName { get; set; }
        public string FatherName { get; set; }
        public string FatherBirthplace { get; set; }
        public string MotherName { get; set; }
        public string MotherBirthplace { get; set; }
    }

   
    public enum ValidIds
    {
        [Display(Name= @"Passport ID")]
        Passport =1,
        [Display(Name = @"Voter's ID")]
        VotersId =2,
        [Display(Name = @"Driver's ID")]
        DriversId =3,

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
