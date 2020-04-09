using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2_ASP_NET.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    AuId = table.Column<string>(nullable: false),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.AuId);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    AuId = table.Column<string>(nullable: false),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.AuId);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    CourseId = table.Column<string>(nullable: false),
                    Semester = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    StudentAuId = table.Column<string>(nullable: true),
                    CourseId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Course_CourseId1",
                        column: x => x.CourseId1,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Student_StudentAuId",
                        column: x => x.StudentAuId,
                        principalTable: "Student",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    HelpWhere = table.Column<string>(nullable: true),
                    CourseId = table.Column<string>(nullable: true),
                    TeacherId = table.Column<string>(nullable: true),
                    CourseId1 = table.Column<string>(nullable: true),
                    TeacherAuId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Assignment_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignment_Course_CourseId1",
                        column: x => x.CourseId1,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignment_Teacher_TeacherAuId",
                        column: x => x.TeacherAuId,
                        principalTable: "Teacher",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignment_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Number = table.Column<int>(nullable: false),
                    Lecture = table.Column<string>(nullable: false),
                    HelpWhere = table.Column<string>(nullable: true),
                    CourseId = table.Column<string>(nullable: true),
                    TeacherId = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true),
                    CourseId1 = table.Column<string>(nullable: true),
                    StudentAuId = table.Column<string>(nullable: true),
                    TeacherAuId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => new { x.Lecture, x.Number });
                    table.ForeignKey(
                        name: "FK_Exercise_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exercise_Course_CourseId1",
                        column: x => x.CourseId1,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exercise_Student_StudentAuId",
                        column: x => x.StudentAuId,
                        principalTable: "Student",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exercise_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exercise_Teacher_TeacherAuId",
                        column: x => x.TeacherAuId,
                        principalTable: "Teacher",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exercise_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCourse",
                columns: table => new
                {
                    TeacherId = table.Column<string>(nullable: false),
                    CourseId = table.Column<string>(nullable: false),
                    TeacherAuId = table.Column<string>(nullable: true),
                    CourseId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCourse", x => new { x.TeacherId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_TeacherCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherCourse_Course_CourseId1",
                        column: x => x.CourseId1,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeacherCourse_Teacher_TeacherAuId",
                        column: x => x.TeacherAuId,
                        principalTable: "Teacher",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeacherCourse_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAssignment",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    AssignmentName = table.Column<string>(nullable: false),
                    StudentAuId = table.Column<string>(nullable: true),
                    AssignmentName1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAssignment", x => new { x.StudentId, x.AssignmentName });
                    table.ForeignKey(
                        name: "FK_StudentAssignment_Assignment_AssignmentName",
                        column: x => x.AssignmentName,
                        principalTable: "Assignment",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAssignment_Assignment_AssignmentName1",
                        column: x => x.AssignmentName1,
                        principalTable: "Assignment",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentAssignment_Student_StudentAuId",
                        column: x => x.StudentAuId,
                        principalTable: "Student",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentAssignment_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "AuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_CourseId",
                table: "Assignment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_CourseId1",
                table: "Assignment",
                column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_TeacherAuId",
                table: "Assignment",
                column: "TeacherAuId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_TeacherId",
                table: "Assignment",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_CourseId",
                table: "Exercise",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_CourseId1",
                table: "Exercise",
                column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_StudentAuId",
                table: "Exercise",
                column: "StudentAuId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_StudentId",
                table: "Exercise",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_TeacherAuId",
                table: "Exercise",
                column: "TeacherAuId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercise_TeacherId",
                table: "Exercise",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssignment_AssignmentName",
                table: "StudentAssignment",
                column: "AssignmentName");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssignment_AssignmentName1",
                table: "StudentAssignment",
                column: "AssignmentName1");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAssignment_StudentAuId",
                table: "StudentAssignment",
                column: "StudentAuId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseId",
                table: "StudentCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseId1",
                table: "StudentCourse",
                column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StudentAuId",
                table: "StudentCourse",
                column: "StudentAuId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourse_CourseId",
                table: "TeacherCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourse_CourseId1",
                table: "TeacherCourse",
                column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourse_TeacherAuId",
                table: "TeacherCourse",
                column: "TeacherAuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "StudentAssignment");

            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.DropTable(
                name: "TeacherCourse");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Teacher");
        }
    }
}
