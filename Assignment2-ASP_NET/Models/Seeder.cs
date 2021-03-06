﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;

namespace Assignment2_ASP_NET.Models
{
    public class Seeder
    {
        public static IEnumerable<Course> SeedCourses()
        {
            return new List<Course>()
            {
                new Course(){CourseId = "GUI", Name = "GUI programming"},
                new Course(){CourseId = "DAB", Name = "Databaser"},
                new Course(){CourseId = "NGK", Name = "Netværksprogrammering og grundlæggende kommunikationsnetværk"},
                new Course(){CourseId = "SWD", Name = "Software design"},
                new Course(){CourseId = "SWT", Name = "Software test"},
                new Course(){CourseId = "DOA", Name = "Datastrukturer og algoritmer"},
                new Course(){CourseId = "ISU", Name = "Indlejret softwareudvikling"},
                new Course(){CourseId = "DSB", Name = "Digital signalbehandling"},
                new Course(){CourseId = "GFV", Name = "Grænseflader til den fysiske verden"},
                new Course(){CourseId = "HAL", Name = "Hardware abstraktioner"},
            };
        }

        public static IEnumerable<Teacher> SeedTeachers()
        {
            return new List<Teacher>()
            {
                new Teacher(){AuId = "au000001", Firstname = "Henrik", Lastname = "Bitsch Kirk"},
                new Teacher(){AuId = "au000002", Firstname = "Jung", Lastname = "Min Kim"},
                new Teacher(){AuId = "au000003", Firstname = "Lene", Lastname = "Häuser Petersen"},
                new Teacher(){AuId = "au000004", Firstname = "Poul", Lastname = "Ejnar Rovsing"},
                new Teacher(){AuId = "au000005", Firstname = "Michael", Lastname = "Alrøe"},
                new Teacher(){AuId = "au000006", Firstname = "Frank", Lastname = "Bodholdt Jakobsen"},
                new Teacher(){AuId = "au000007", Firstname = "Michael", Lastname = "Sørensen Loft"},
                new Teacher(){AuId = "au000008", Firstname = "Peter", Lastname = "Høgh Mikkelsen"},
                new Teacher(){AuId = "au000009", Firstname = "Jesper", Lastname = "Rosholm Tørresø"},
                new Teacher(){AuId = "au000010", Firstname = "Lars", Lastname = "G. Johansen"},
                new Teacher(){AuId = "au000011", Firstname = "Arne", Lastname = "Justesen"},
                new Teacher(){AuId = "au000012", Firstname = "Martin", Lastname = "Ansbjerg Kjær"},
                new Teacher(){AuId = "au000013", Firstname = "Per", Lastname = "Lysgaard"},
                new Teacher(){AuId = "au000014", Firstname = "Søren", Lastname = "Hansen"},
                new Teacher(){AuId = "au000015", Firstname = "Søren", Lastname = "H. Nielsen"}
            };
        }

        public static IEnumerable<Student> SeedStudents()
        {
            return new List<Student>()
            {
                new Student(){AuId = "au100001", Firstname = "Jeppe", Lastname = "Larsen"},
                new Student(){AuId = "au100002", Firstname = "Mikkel", Lastname = "Rasmussen"},
                new Student(){AuId = "au100003", Firstname = "Andreas", Lastname = "Larsen"},
                new Student(){AuId = "au100004", Firstname = "Mathias", Lastname = "Madsen"},
                new Student(){AuId = "au100005", Firstname = "Jakob", Lastname = "Jakobsen"},
                new Student(){AuId = "au100006", Firstname = "Magnus", Lastname = "Dalager"},
                new Student(){AuId = "au100007", Firstname = "Morten", Lastname = "Jensen"},
                new Student(){AuId = "au100008", Firstname = "Peter", Lastname = "Palland"},
                new Student(){AuId = "au100009", Firstname = "Frederik", Lastname = "Karlsmose"},
                new Student(){AuId = "au100010", Firstname = "Anne", Lastname = "Dyhbdal"},
                new Student(){AuId = "au100011", Firstname = "Martin", Lastname = "Sørensen"},
                new Student(){AuId = "au100012", Firstname = "Astrid", Lastname = "Ravn"},
                new Student(){AuId = "au100013", Firstname = "Emil", Lastname = "Johansen"},
                new Student(){AuId = "au100014", Firstname = "Jonas", Lastname = "Thomsen"},
                new Student(){AuId = "au100015", Firstname = "Jens", Lastname = "Nielsen"},
            };
        }

        public static IEnumerable<TeacherCourse> SeedTeacherCourses()
        {
            return new List<TeacherCourse>()
            {
                new TeacherCourse(){TeacherId = "au000001", CourseId = "DAB"},
                new TeacherCourse(){TeacherId = "au000001", CourseId = "GUI"},
                new TeacherCourse(){TeacherId = "au000001", CourseId = "NGK"},
                new TeacherCourse(){TeacherId = "au000001", CourseId = "SWD"},
                new TeacherCourse(){TeacherId = "au000002", CourseId = "GUI"},
                new TeacherCourse(){TeacherId = "au000002", CourseId = "SWT"},
                new TeacherCourse(){TeacherId = "au000003", CourseId = "GUI"},
                new TeacherCourse(){TeacherId = "au000004", CourseId = "GUI"},
                new TeacherCourse(){TeacherId = "au000004", CourseId = "NGK"},
                new TeacherCourse(){TeacherId = "au000005", CourseId = "NGK"},
                new TeacherCourse(){TeacherId = "au000006", CourseId = "SWT"},
                new TeacherCourse(){TeacherId = "au000006", CourseId = "NGK"},
                new TeacherCourse(){TeacherId = "au000007", CourseId = "SWD"},
                new TeacherCourse(){TeacherId = "au000007", CourseId = "NGK"},
                new TeacherCourse(){TeacherId = "au000007", CourseId = "GFV"},
                new TeacherCourse(){TeacherId = "au000008", CourseId = "DOA"},
                new TeacherCourse(){TeacherId = "au000008", CourseId = "HAL"},
                new TeacherCourse(){TeacherId = "au000009", CourseId = "DOA"},
                new TeacherCourse(){TeacherId = "au000010", CourseId = "DSB"},
                new TeacherCourse(){TeacherId = "au000011", CourseId = "GFV"},
                new TeacherCourse(){TeacherId = "au000012", CourseId = "GFV"},
                new TeacherCourse(){TeacherId = "au000013", CourseId = "HAL"},
                new TeacherCourse(){TeacherId = "au000014", CourseId = "ISU"},
                new TeacherCourse(){TeacherId = "au000015", CourseId = "ISU"},
            };
        }

        public static IEnumerable<StudentCourse> SeedStudentCourses()
        {
            return new List<StudentCourse>()
            {
                new StudentCourse(){StudentId = "au100001", Semester = "F20", Active = true, CourseId = "GUI"},
                new StudentCourse(){StudentId = "au100001", Semester = "F20", Active = true, CourseId = "NGK"},
                new StudentCourse(){StudentId = "au100001", Semester = "F20", Active = true, CourseId = "DAB"},
                new StudentCourse(){StudentId = "au100001", Semester = "F20", Active = true, CourseId = "SWT"},
                new StudentCourse(){StudentId = "au100001", Semester = "F20", Active = true, CourseId = "SWD"},
                new StudentCourse(){StudentId = "au100002", Semester = "F20", Active = true, CourseId = "GUI"},
                new StudentCourse(){StudentId = "au100002", Semester = "F20", Active = true, CourseId = "NGK"},
                new StudentCourse(){StudentId = "au100002", Semester = "F20", Active = true, CourseId = "DAB"},
                new StudentCourse(){StudentId = "au100002", Semester = "F20", Active = true, CourseId = "SWT"},
                new StudentCourse(){StudentId = "au100002", Semester = "F20", Active = true, CourseId = "SWD"},
                new StudentCourse(){StudentId = "au100003", Semester = "F20", Active = true, CourseId = "GUI"},
                new StudentCourse(){StudentId = "au100003", Semester = "F20", Active = true, CourseId = "NGK"},
                new StudentCourse(){StudentId = "au100003", Semester = "F20", Active = true, CourseId = "DAB"},
                new StudentCourse(){StudentId = "au100003", Semester = "F20", Active = true, CourseId = "SWT"},
                new StudentCourse(){StudentId = "au100003", Semester = "F20", Active = true, CourseId = "SWD"},
                new StudentCourse(){StudentId = "au100004", Semester = "F20", Active = true, CourseId = "GUI"},
                new StudentCourse(){StudentId = "au100004", Semester = "F20", Active = true, CourseId = "NGK"},
                new StudentCourse(){StudentId = "au100004", Semester = "F20", Active = true, CourseId = "DAB"},
                new StudentCourse(){StudentId = "au100004", Semester = "F20", Active = true, CourseId = "SWT"},
                new StudentCourse(){StudentId = "au100004", Semester = "F20", Active = true, CourseId = "SWD"},
                new StudentCourse(){StudentId = "au100005", Semester = "F20", Active = true, CourseId = "GUI"},
                new StudentCourse(){StudentId = "au100005", Semester = "F20", Active = true, CourseId = "NGK"},
                new StudentCourse(){StudentId = "au100005", Semester = "F20", Active = true, CourseId = "DAB"},
                new StudentCourse(){StudentId = "au100005", Semester = "F20", Active = true, CourseId = "SWT"},
                new StudentCourse(){StudentId = "au100005", Semester = "F20", Active = true, CourseId = "SWD"},
                new StudentCourse(){StudentId = "au100006", Semester = "F20", Active = true, CourseId = "GUI"},
                new StudentCourse(){StudentId = "au100006", Semester = "F20", Active = true, CourseId = "NGK"},
                new StudentCourse(){StudentId = "au100006", Semester = "F20", Active = true, CourseId = "DAB"},
                new StudentCourse(){StudentId = "au100006", Semester = "F20", Active = true, CourseId = "SWT"},
                new StudentCourse(){StudentId = "au100006", Semester = "F20", Active = true, CourseId = "SWD"},
                new StudentCourse(){StudentId = "au100007", Semester = "F20", Active = true, CourseId = "ISU"},
                new StudentCourse(){StudentId = "au100007", Semester = "F20", Active = true, CourseId = "HAL"},
                new StudentCourse(){StudentId = "au100007", Semester = "F20", Active = true, CourseId = "DOA"},
                new StudentCourse(){StudentId = "au100007", Semester = "F20", Active = true, CourseId = "GFV"},
                new StudentCourse(){StudentId = "au100007", Semester = "F20", Active = true, CourseId = "DSB"},
                new StudentCourse(){StudentId = "au100008", Semester = "F20", Active = true, CourseId = "ISU"},
                new StudentCourse(){StudentId = "au100008", Semester = "F20", Active = true, CourseId = "HAL"},
                new StudentCourse(){StudentId = "au100008", Semester = "F20", Active = true, CourseId = "DOA"},
                new StudentCourse(){StudentId = "au100008", Semester = "F20", Active = true, CourseId = "GFV"},
                new StudentCourse(){StudentId = "au100008", Semester = "F20", Active = true, CourseId = "DSB"},
                new StudentCourse(){StudentId = "au100009", Semester = "F20", Active = true, CourseId = "ISU"},
                new StudentCourse(){StudentId = "au100009", Semester = "F20", Active = true, CourseId = "HAL"},
                new StudentCourse(){StudentId = "au100009", Semester = "F20", Active = true, CourseId = "DOA"},
                new StudentCourse(){StudentId = "au100009", Semester = "F20", Active = true, CourseId = "GFV"},
                new StudentCourse(){StudentId = "au100009", Semester = "F20", Active = true, CourseId = "DSB"},
                new StudentCourse(){StudentId = "au100010", Semester = "F20", Active = true, CourseId = "ISU"},
                new StudentCourse(){StudentId = "au100010", Semester = "F20", Active = true, CourseId = "HAL"},
                new StudentCourse(){StudentId = "au100010", Semester = "F20", Active = true, CourseId = "DOA"},
                new StudentCourse(){StudentId = "au100010", Semester = "F20", Active = true, CourseId = "GFV"},
                new StudentCourse(){StudentId = "au100010", Semester = "F20", Active = true, CourseId = "DSB"},
                new StudentCourse(){StudentId = "au100011", Semester = "F20", Active = true, CourseId = "ISU"},
                new StudentCourse(){StudentId = "au100011", Semester = "F20", Active = true, CourseId = "HAL"},
                new StudentCourse(){StudentId = "au100011", Semester = "F20", Active = true, CourseId = "DOA"},
                new StudentCourse(){StudentId = "au100011", Semester = "F20", Active = true, CourseId = "GFV"},
                new StudentCourse(){StudentId = "au100011", Semester = "F20", Active = true, CourseId = "DSB"},
                new StudentCourse(){StudentId = "au100012", Semester = "F20", Active = true, CourseId = "ISU"},
                new StudentCourse(){StudentId = "au100012", Semester = "F20", Active = true, CourseId = "HAL"},
                new StudentCourse(){StudentId = "au100012", Semester = "F20", Active = true, CourseId = "DOA"},
                new StudentCourse(){StudentId = "au100012", Semester = "F20", Active = true, CourseId = "GFV"},
                new StudentCourse(){StudentId = "au100012", Semester = "F20", Active = true, CourseId = "DSB"},
                new StudentCourse(){StudentId = "au100013", Semester = "F20", Active = true, CourseId = "SWD"},
                new StudentCourse(){StudentId = "au100013", Semester = "F20", Active = true, CourseId = "SWT"},
                new StudentCourse(){StudentId = "au100013", Semester = "F20", Active = true, CourseId = "NGK"},
                new StudentCourse(){StudentId = "au100013", Semester = "F20", Active = true, CourseId = "GFV"},
                new StudentCourse(){StudentId = "au100014", Semester = "F20", Active = true, CourseId = "SWD"},
                new StudentCourse(){StudentId = "au100014", Semester = "F20", Active = true, CourseId = "SWT"},
                new StudentCourse(){StudentId = "au100014", Semester = "F20", Active = true, CourseId = "NGK"},
                new StudentCourse(){StudentId = "au100014", Semester = "F20", Active = true, CourseId = "GFV"},
                new StudentCourse(){StudentId = "au100015", Semester = "F20", Active = true, CourseId = "SWD"},
                new StudentCourse(){StudentId = "au100015", Semester = "F20", Active = true, CourseId = "SWT"},
                new StudentCourse(){StudentId = "au100015", Semester = "F20", Active = true, CourseId = "NGK"},
                new StudentCourse(){StudentId = "au100015", Semester = "F20", Active = true, CourseId = "GFV"},
            };
        }

        public static IEnumerable<Exercise> SeedExercises()
        {
            return new List<Exercise>()
            {
                new Exercise() { CourseId = "DAB", TeacherId = "au000001", StudentId = "au100005", Lecture = "EF Core - Migrations", Number = 6, HelpWhere = "Benjamin", Open = true},
                new Exercise() { CourseId = "DAB", TeacherId = "au000001", StudentId = "au100003", Lecture = "ER Core - Query + Manipulation", Number = 7, HelpWhere = "Edison", Open = true},
                new Exercise() { CourseId = "DAB", TeacherId = "au000001", StudentId = "au100001", Lecture = "EF Core patterns + DDD", Number = 9, HelpWhere = "Edison", Open = true },
                new Exercise() { CourseId = "GUI", TeacherId = "au000001", StudentId = "au100005", Lecture = "Razor og Tables i HTML", Number = 18, HelpWhere = "Nygaard", Open = true },
                new Exercise() { CourseId = "GUI", TeacherId = "au000004", StudentId = "au100001", Lecture = "Windows and Dialogs", Number = 10, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "DOA", TeacherId = "au000008", StudentId = "au100010", Lecture = "Treaps", Number = 5, HelpWhere = "Nygaard", Open = true },
                new Exercise() { CourseId = "DOA", TeacherId = "au000008", StudentId = "au100007", Lecture = "Pathfinding: A*", Number = 10, HelpWhere = "Nygaard", Open = true },
                new Exercise() { CourseId = "DOA", TeacherId = "au000009", StudentId = "au100008", Lecture = "Maximum Flow", Number = 11, HelpWhere = "Nygaard", Open = true },
                new Exercise() { CourseId = "ISU", TeacherId = "au000014", StudentId = "au100009", Lecture = "OSAPI", Number = 6, HelpWhere = "Benjamin", Open = true },
                new Exercise() { CourseId = "ISU", TeacherId = "au000014", StudentId = "au100012", Lecture = "Message Queue", Number = 3, HelpWhere = "Benjamin", Open = true },
                new Exercise() { CourseId = "ISU", TeacherId = "au000014", StudentId = "au100010", Lecture = "Observer, Mediator, Singleton", Number = 9, HelpWhere = "Benjamin", Open = true },
                new Exercise() { CourseId = "ISU", TeacherId = "au000014", StudentId = "au100009", Lecture = "Mutex", Number = 2, HelpWhere = "Benjamin", Open = true },
                new Exercise() { CourseId = "ISU", TeacherId = "au000015", StudentId = "au100007", Lecture = "Semaphore", Number = 2, HelpWhere = "Benjamin", Open = true },
                new Exercise() { CourseId = "HAL", TeacherId = "au000008", StudentId = "au100008", Lecture = "Interrupts", Number = 5, HelpWhere = "Benjamin", Open = true },
                new Exercise() { CourseId = "NGK", TeacherId = "au000004", StudentId = "au100006", Lecture = "Transport Layer - TCP", Number = 8, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "NGK", TeacherId = "au000005", StudentId = "au100001", Lecture = "WebAPI", Number = 10, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "GFV", TeacherId = "au000007", StudentId = "au100011", Lecture = "AJU Statiske & dynamiske karakteristikker", Number = 3, HelpWhere = "Nygaard", Open = true },
                new Exercise() { CourseId = "GFV", TeacherId = "au000011", StudentId = "au100015", Lecture = "Communication buses", Number = 2, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "GFV", TeacherId = "au000011", StudentId = "au100009", Lecture = "AJU Støjindkobling", Number = 4, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "DSB", TeacherId = "au000010", StudentId = "au100008", Lecture = "Lektion 8", Number = 8, HelpWhere = "Benjamin", Open = true },
                new Exercise() { CourseId = "DSB", TeacherId = "au000010", StudentId = "au100007", Lecture = "Lektion 5", Number = 5, HelpWhere = "Benjamin", Open = true },
                new Exercise() { CourseId = "SWD", TeacherId = "au000001", StudentId = "au100002", Lecture = "SOLID 2 (LSP, ISP, DIP)", Number = 2, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "SWD", TeacherId = "au000001", StudentId = "au100001", Lecture = "GoF Template Method + GoF Strategy", Number = 1, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "SWD", TeacherId = "au000001", StudentId = "au100014", Lecture = "State Machines + GoF State", Number = 3, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "SWD", TeacherId = "au000007", StudentId = "au100006", Lecture = "Functional Programming", Number = 3, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "SWD", TeacherId = "au000007", StudentId = "au100015", Lecture = "Refactoring", Number = 1, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "SWD", TeacherId = "au000007", StudentId = "au100004", Lecture = "Factories", Number = 2, HelpWhere = "Shannon", Open = true },
                new Exercise() { CourseId = "SWT", TeacherId = "au000002", StudentId = "au100013", Lecture = "Fakes og Isolation Frameworks", Number = 1, HelpWhere = "Nygaard", Open = true },
                new Exercise() { CourseId = "SWT", TeacherId = "au000006", StudentId = "au100002", Lecture = "Test Quality", Number = 2, HelpWhere = "Benjamin", Open = true },
                new Exercise() { CourseId = "SWT", TeacherId = "au000006", StudentId = "au100001", Lecture = "Software Quality Metrics", Number = 2, HelpWhere = "Benjamin", Open = true },
            };
        }

        public static IEnumerable<Assignment> SeedAssignments()
        {
            return new List<Assignment>()
            {
                new Assignment(){Name = "Obligatorisk Opgave II", TeacherId = "au000002", CourseId = "SWT", HelpWhere = "Benjamin", Open = true},
                new Assignment(){Name = "Obligatorisk Opgave II", TeacherId = "au000006", CourseId = "SWT", HelpWhere = "Zoom", Open = true},
                new Assignment(){Name = "Assignment #2", TeacherId = "au000005", CourseId = "NGK", HelpWhere = "Shannon", Open = true},
                new Assignment(){Name = "Assignment #3", TeacherId = "au000004", CourseId = "NGK", HelpWhere = "Zoom", Open = true},
                new Assignment(){Name = "Assignment 1", TeacherId = "au000001", CourseId = "DAB", HelpWhere = "Edison", Open = true},
                new Assignment(){Name = "Assignment 2", TeacherId = "au000001", CourseId = "DAB", HelpWhere = "Zoom", Open = true},
                new Assignment(){Name = "Obligatorisk Opgave 2", TeacherId = "au000004", CourseId = "GUI", HelpWhere = "Nyggard", Open = true},
                new Assignment(){Name = "Obligatorisk Handin", TeacherId = "au000001", CourseId = "SWD", HelpWhere = "Shannon", Open = true},
                new Assignment(){Name = "Mutex", TeacherId = "au000014", CourseId = "ISU", HelpWhere = "Benjamin", Open = true},
                new Assignment(){Name = "RAII", TeacherId = "au000014", CourseId = "ISU", HelpWhere = "Benjamin", Open = true},
                new Assignment(){Name = "SPI", TeacherId = "au000008", CourseId = "HAL", HelpWhere = "Benjamin", Open = true},
                new Assignment(){Name = "Assignment 4", TeacherId = "au000010", CourseId = "DSB", HelpWhere = "Benjamin", Open = true},
                new Assignment(){Name = "Lab Experiment 2", TeacherId = "au000011", CourseId = "GFV", HelpWhere = "Shannon", Open = true},
                new Assignment(){Name = "Lab Experiment 3", TeacherId = "au000007", CourseId = "GFV", HelpWhere = "Shannon", Open = true},
                new Assignment(){Name = "Obligatorisk Handin", TeacherId = "au000008", CourseId = "DOA", HelpWhere = "Kahn", Open = true}
            };
        }

        public static IEnumerable<StudentAssignment> SeedStudentAssignments(IEnumerable<Assignment> assignments)
        {
            var assignmentSeedList = assignments.ToList();

            return new List<StudentAssignment>()
            {
                new StudentAssignment(){HelpRequestId = assignmentSeedList[0].HelpRequestId, StudentId = "au100005"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[0].HelpRequestId, StudentId = "au100004"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[1].HelpRequestId, StudentId = "au100001"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[1].HelpRequestId, StudentId = "au100002"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[1].HelpRequestId, StudentId = "au100006"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[2].HelpRequestId, StudentId = "au100015"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[2].HelpRequestId, StudentId = "au100014"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[2].HelpRequestId, StudentId = "au100013"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[3].HelpRequestId, StudentId = "au100004"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[3].HelpRequestId, StudentId = "au100005"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[4].HelpRequestId, StudentId = "au100006"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[4].HelpRequestId, StudentId = "au100005"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[5].HelpRequestId, StudentId = "au100001"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[5].HelpRequestId, StudentId = "au100002"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[6].HelpRequestId, StudentId = "au100003"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[6].HelpRequestId, StudentId = "au100004"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[6].HelpRequestId, StudentId = "au100001"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[7].HelpRequestId, StudentId = "au100001"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[7].HelpRequestId, StudentId = "au100002"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[7].HelpRequestId, StudentId = "au100006"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[8].HelpRequestId, StudentId = "au100010"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[8].HelpRequestId, StudentId = "au100011"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[9].HelpRequestId, StudentId = "au100007"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[9].HelpRequestId, StudentId = "au100008"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[10].HelpRequestId, StudentId = "au100009"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[11].HelpRequestId, StudentId = "au100010"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[12].HelpRequestId, StudentId = "au100013"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[12].HelpRequestId, StudentId = "au100014"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[12].HelpRequestId, StudentId = "au100015"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[13].HelpRequestId, StudentId = "au100010"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[13].HelpRequestId, StudentId = "au100011"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[13].HelpRequestId, StudentId = "au100012"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[14].HelpRequestId, StudentId = "au100008"},
                new StudentAssignment(){HelpRequestId = assignmentSeedList[14].HelpRequestId, StudentId = "au100009"}
            };
        }
    }
}
