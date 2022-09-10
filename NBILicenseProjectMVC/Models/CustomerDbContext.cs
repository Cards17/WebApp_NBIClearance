using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace NBILicenseProjectMVC.Models
{
    public partial class CustomerDbContext : DbContext
    {
        public CustomerDbContext()
        {
        }

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Applicant> Applicant { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=nbiclearanceserver.database.windows.net;Initial Catalog=nbiclearancedatabase;Persist Security Info=False;User ID=adminuser;Password=Piquero@17;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApplicantPicture)
                    .IsRequired()
                    .HasColumnName("applicant_picture")
                    .IsUnicode(false);

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasColumnName("branch_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CivilStatus)
                    .IsRequired()
                    .HasColumnName("civil_status")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Complexion)
                    .HasColumnName("complexion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.EducationalAttainment)
                    .HasColumnName("educational_attainment")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FatherBirthplace)
                    .HasColumnName("father_birthplace")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasColumnName("father_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasColumnType("decimal(9, 3)");

                entity.Property(e => e.HusbandOrWifeName)
                    .HasColumnName("husband_or_wife_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LandlineNumber)
                    .HasColumnName("landline_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Middlename)
                    .IsRequired()
                    .HasColumnName("middlename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasColumnName("mobile_number")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MotherBirthplace)
                    .HasColumnName("mother_birthplace")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasColumnName("mother_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Peculiarities)
                    .HasColumnName("peculiarities")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Religion)
                    .HasColumnName("religion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidId)
                    .IsRequired()
                    .HasColumnName("valid_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(9, 3)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
