using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NBILicenseProject.Models
{
    public partial class Applicant
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public DateTime Date { get; set; }
        public string ValidId { get; set; }
        public string ApplicantPicture { get; set; }
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
}
