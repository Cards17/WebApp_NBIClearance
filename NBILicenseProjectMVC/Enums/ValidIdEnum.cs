using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NBILicenseProjectMVC.Enums
{
        public enum ValidIds
        {
            [Display(Name = @"Passport ID")]
            Passport,
            [Display(Name = @"Voter's ID")]
            Voter,
            [Display(Name = @"Driver's ID")]
            Driver,
            [Display(Name = @"PRC License")]
            PRC,
            [Display(Name = @"SSS ID")]
            SSS,
            [Display(Name = @"GSIS ID")]
            GSIS,
            [Display(Name = @"UMID")]
            UMID,
            [Display(Name = @"Postal ID")]
            Postal,
            [Display(Name = @"School ID")]
            School,
            [Display(Name = @"TIN ID")]
            TIN,
            [Display(Name = @"Philhealth ID")]
            PhilHealth,
            [Display(Name = @"Authenticated Birth Certificate")]
            BirthCertificate,
            [Display(Name = @"Alien Certificate of Registration")]
            AlienCertificate,
            [Display(Name = @"Senior Citizen ID")]
            SeniorCitizen,
            [Display(Name = @"Copy of Previous Clearance")]
            PreviousClearance,
        }
    }
