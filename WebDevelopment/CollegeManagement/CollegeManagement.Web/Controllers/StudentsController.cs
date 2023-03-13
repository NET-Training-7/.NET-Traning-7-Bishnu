using Microsoft.AspNetCore.Mvc;
using CollegeManagement.Web.Models;
using CollegeManagement.Web.Data;

namespace CollegeManagement.Web.Controllers;
public class StudentsController : Controller
{
    CollegeDbConext db = new CollegeDbConext();
    
    public IActionResult Index()
    {   
        var students = db.Students.ToList();
        return View(students);
    }
        
    public IActionResult Details(int id)
    {
        var student = db.Students.Find(id);// select * from Students where Id = id
        return View(student);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Student student)
    {
        db.Students.Add(student);
        db.SaveChanges();

        return RedirectToAction("Index");
    }
}
