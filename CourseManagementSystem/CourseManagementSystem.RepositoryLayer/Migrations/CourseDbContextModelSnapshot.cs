﻿// <auto-generated />
using CourseManagementSystem.RepositoryLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseManagementSystem.RepositoryLayer.Migrations
{
    [DbContext(typeof(CourseDbContext))]
    partial class CourseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseManagementSystem.DomainLayer.Course", b =>
                {
                    b.Property<int>("Course_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Course_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course_Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course_Instructor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Course_Id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("CourseManagementSystem.DomainLayer.RegisteredStudentList", b =>
                {
                    b.Property<int>("registered_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("start_Date")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("registered_id");

                    b.ToTable("registerstudent");
                });

            modelBuilder.Entity("CourseManagementSystem.DomainLayer.Registration", b =>
                {
                    b.Property<int>("Registration_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<string>("Course_StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("student_ID")
                        .HasColumnType("int");

                    b.HasKey("Registration_Id");

                    b.ToTable("register");
                });

            modelBuilder.Entity("CourseManagementSystem.DomainLayer.Student", b =>
                {
                    b.Property<int>("student_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Contact_No")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("student_Id");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}