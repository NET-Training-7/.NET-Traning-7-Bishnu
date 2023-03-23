using Microsoft.AspNetCore.Mvc;
using CollegeManagement.Web.Models;
using CollegeManagement.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CollegeManagement.Web.Extensions;
using CollegeManagement.Web.ViewModels;
using CollegeManagement.Web.Mappers;

namespace CollegeManagement.Web.Controllers;
public class StudentsController : Controller
{
    private readonly CollegeDbConext db;

    public StudentsController(CollegeDbConext _db)
    {
        db = _db;
    }

    public async Task<IActionResult> Index()
    {
        var students = await db.Students.ToListAsync();

        var studentViewModels = students.ToViewModel();

        return View(studentViewModels);
    }

    public async Task<IActionResult> Details(int id)
    {
        var student = await db.Students.FindAsync(id);// select * from Students where Id = id
        var studentViewModel = student.ToViewModel();
        return View(studentViewModel);
    }

    public IActionResult Add()
    {
        var majorsList = db.Majors.ToList();
        var majors = majorsList.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
        ViewData["Majors"] = majors;

        return View();
    }

    [HttpPost]
    public IActionResult Add(StudentViewModel studentVM)
    {
        if (studentVM == null || !ModelState.IsValid)
            return View("Error", new ErrorViewModel { RequestId = "Register Student" });

        string avatarPath = studentVM.Avatar.SaveProfileImage();

        var student = studentVM.ToModel();

        student.AvatarPath= avatarPath;
        db.Students.Add(student);
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var student = db.Students.Find(id);
        return View(student.ToViewModel());
    }

    [HttpPost]
    public IActionResult Edit(StudentViewModel studentVM)
    {
        if (studentVM == null || !ModelState.IsValid)
            return View("Error", new ErrorViewModel { RequestId = "Update Student" });

        var student = studentVM.ToModel();

        if (studentVM.Avatar is not null)
        {
            var path = studentVM.Avatar.SaveProfileImage();            
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
