using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseManagementSystem.RepositoryLayer.Migrations
{
    public partial class courses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Course_Id = table.Column<int>(type: "int", nullable: false)
                        ,
                    Course_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course_Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course_Instructor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Course_Id);
                });

            migrationBuilder.CreateTable(
                name: "register",
                columns: table => new
                {
                    Registration_Id = table.Column<int>(type: "int", nullable: false)
                        ,
                    Course_StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    student_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_register", x => x.Registration_Id);
                });

            migrationBuilder.CreateTable(
                name: "registerstudent",
                columns: table => new
                {
                    registered_id = table.Column<int>(type: "int", nullable: false)
                        ,
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    courseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    courseDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_Date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registerstudent", x => x.registered_id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    student_Id = table.Column<int>(type: "int", nullable: false)
                        ,
                    Student_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_No = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.student_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "register");

            migrationBuilder.DropTable(
                name: "registerstudent");

            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
