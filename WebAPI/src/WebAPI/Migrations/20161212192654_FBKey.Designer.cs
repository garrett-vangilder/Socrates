using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAPI.Data;

namespace WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161212192654_FBKey")]
    partial class FBKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssingmentTypeId");

                    b.Property<DateTime>("DueDate");

                    b.Property<int>("TotalPossiblePoints");

                    b.HasKey("AssignmentId");

                    b.ToTable("Assignment");
                });

            modelBuilder.Entity("WebAPI.Models.AssingmentType", b =>
                {
                    b.Property<int>("AssingmentTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GradeBookId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PercentageOutOf100");

                    b.HasKey("AssingmentTypeId");

                    b.ToTable("AssingmentType");
                });

            modelBuilder.Entity("WebAPI.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassPeriodId");

                    b.Property<int>("EducatorId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Subject");

                    b.HasKey("ClassId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("WebAPI.Models.ClassMember", b =>
                {
                    b.Property<int>("ClassMemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClassId")
                        .IsRequired();

                    b.Property<int>("StudentId");

                    b.HasKey("ClassMemberId");

                    b.ToTable("ClassMember");
                });

            modelBuilder.Entity("WebAPI.Models.ClassPeriod", b =>
                {
                    b.Property<int>("ClassPeriodId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EndTime")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("SchoolId");

                    b.Property<string>("StartTime")
                        .IsRequired();

                    b.HasKey("ClassPeriodId");

                    b.ToTable("ClassPeriod");
                });

            modelBuilder.Entity("WebAPI.Models.Educator", b =>
                {
                    b.Property<int>("EducatorId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admin");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("FirebaseUid");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<long>("PhoneNumber");

                    b.Property<int?>("SchoolId");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("StreetAddress")
                        .IsRequired();

                    b.Property<int>("ZipCode");

                    b.HasKey("EducatorId");

                    b.ToTable("Educator");
                });

            modelBuilder.Entity("WebAPI.Models.Grade", b =>
                {
                    b.Property<int>("GradeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AssingmentId");

                    b.Property<int>("ClassMemberId");

                    b.Property<int>("PointsEarned");

                    b.HasKey("GradeId");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("WebAPI.Models.GradeBook", b =>
                {
                    b.Property<int>("GradeBookId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassId");

                    b.Property<int>("EducatorId");

                    b.HasKey("GradeBookId");

                    b.ToTable("GradeBook");
                });

            modelBuilder.Entity("WebAPI.Models.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("EmailAddress")
                        .IsRequired();

                    b.Property<string>("EndTime")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<long>("PhoneNumber");

                    b.Property<string>("SchoolWebSiteUrl")
                        .IsRequired();

                    b.Property<string>("StartTime")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("StreetAddress")
                        .IsRequired();

                    b.Property<int>("ZipCode");

                    b.HasKey("SchoolId");

                    b.ToTable("School");
                });

            modelBuilder.Entity("WebAPI.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("FirebaseUid")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("Grade");

                    b.Property<string>("GuardianEmailAddress")
                        .IsRequired();

                    b.Property<string>("GuardianFirstName")
                        .IsRequired();

                    b.Property<string>("GuardianLastName")
                        .IsRequired();

                    b.Property<long>("GuardianPhoneNumber");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("SchoolId");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("StreetAddress")
                        .IsRequired();

                    b.Property<int>("ZipCode");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });
        }
    }
}
