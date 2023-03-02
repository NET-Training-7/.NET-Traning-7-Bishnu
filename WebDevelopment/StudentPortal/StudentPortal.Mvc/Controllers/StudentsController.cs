using Microsoft.AspNetCore.Mvc;
using StudentPortal.Mvc.Models;

namespace StudentPortal.Mvc.Controllers;
public class StudentsController : Controller
{
    public IActionResult Home()
    {
        var s1 = new Student { Name = "Roshan Twayana", RollNo = 353, Contact = "98933424234", Major = "Science", Semester = "III" };
        var s2 = new Student { Name = "Roshan Shrestha", RollNo = 23353, Contact = "9851342434", Major = "Arts", Semester = "II" };
        var s3 = new Student { Name = "Samuel Gurung", RollNo = 10353, Contact = "9893389234", Major = "Education", Semester = "IV" };
        var s4 = new Student { Name = "Roshan Twayana", RollNo = 34353, Contact = "981024234", Major = "Science", Semester = "VI" };
        List<Student> students = new() { s1, s2, s3, s4 };

        return View(students);
    }

    public IActionResult Add()
    {
        return View();
    }
}
