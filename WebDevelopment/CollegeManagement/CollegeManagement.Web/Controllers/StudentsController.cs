using Microsoft.AspNetCore.Mvc;
using CollegeManagement.Web.Models;
using CollegeManagement.Web.Data;
using F = System.IO.File;
using CollegeManagement.Web.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        var majorsList = db.Majors.ToList();
        var majors = majorsList.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
        ViewData["Majors"] = majors;

        return View();
    }

    [HttpPost]
    public IActionResult Add(Student student)
    {
        if(student == null || !ModelState.IsValid)
            return View("Error", new ErrorViewModel { RequestId = "Register Student" });

        string avatarPath = FormImageHelper.SaveProfileImage(student.Avatar!);
        
        student.AvatarPath = avatarPath;
        db.Students.Add(student);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var student = db.Students.Find(id);
        return View(student);
    }

    [HttpPost]
    public IActionResult Edit(Student student)
    {
        if (student == null || !ModelState.IsValid)
            return View("Error", new ErrorViewModel { RequestId = "Update Student" });

        if(student.Avatar is not null)
        {
            var path = FormImageHelper.SaveProfileImage(student.Avatar);
            student.AvatarPath = path;
        }

        db.Students.Update(student);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult DeleteConfirm(int id)
    {
        var student = db.Students.Find(id);
        return View(student);
    }

    [HttpPost]
    public IActionResult Delete(Student student)
    {   
        db.Students.Remove(student);
        db.SaveChanges();

        return RedirectToAction("Index");
    }
}
