using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_ASP_NET.Database.Models;
using Assignment2_ASP_NET.Database.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment2_ASP_NET.Models;

namespace Assignment2_ASP_NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SeedDatabase()
        {
            IEnumerable<Course> courses = new List<Course>()
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

            IEnumerable<Teacher> teachers = new List<Teacher>()
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

            IEnumerable<Student> students = new List<Student>()
            {
                new Student(){AuId = "au100001", Firstname = "Jeppe", Lastname = "Larsen"},
                new Student(){AuId = "au100002", Firstname = "Mikkel", Lastname = "Rasmussen"},
                new Student(){AuId = "au100003", Firstname = "Jacob", Lastname = "Valdemar"},
                new Student(){AuId = "au100004", Firstname = "Anders", Lastname = "Tøgersen"},
                new Student(){AuId = "au100005", Firstname = "Jonas", Lastname = "Axelsen"},
                new Student(){AuId = "au100006", Firstname = "Frederik", Lastname = "Dalager"},
                new Student(){AuId = "au100007", Firstname = "Morten", Lastname = "Ehlers"},
                new Student(){AuId = "au100008", Firstname = "", Lastname = ""},
                new Student(){AuId = "au100009", Firstname = "", Lastname = ""},
                new Student(){AuId = "au100010", Firstname = "", Lastname = ""},
                new Student(){AuId = "au100011", Firstname = "", Lastname = ""},
                new Student(){AuId = "au100012", Firstname = "", Lastname = ""},
                new Student(){AuId = "au100013", Firstname = "", Lastname = ""},
                new Student(){AuId = "au100014", Firstname = "", Lastname = ""},
                new Student(){AuId = "au100015", Firstname = "", Lastname = ""},
            };

            _unitOfWork.CourseRepository.AddRange(courses);


            return View("Index");
        }
    }
}
