using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_EF_Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_ASP_NET.Controllers
{
    public class HelpRequestController : Controller
    {
        public IActionResult Overview()
        {
            return View();
        }

        public IActionResult GetForStudent(int studentAuId)
        {

        }

        public IActionResult GetForTeacherCourse(string teacherAuId, int courseId)
        {

        }

        public IActionResult Statistics()
        {


            return View();
        }


    }
}