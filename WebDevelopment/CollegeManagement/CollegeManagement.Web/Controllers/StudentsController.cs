using Microsoft.AspNetCore.Mvc;
using CollegeManagement.Web.Models;
using CollegeManagement.Web.Data;

namespace CollegeManagement.Web.Controllers;
public class StudentsController : Controller
{
    public IActionResult Index()
    {   
        CollegeDbConext db = new CollegeDbConext();
        var students = db.Students.ToList();
        return View(students);
    }

    //public IActionResult Details(int id)
    //{
    //    var student = students.Where(x => x.RollNo == id).FirstOrDefault();
    //    return View(student);
    //}
}
