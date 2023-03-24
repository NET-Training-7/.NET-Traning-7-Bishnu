using Microsoft.AspNetCore.Mvc;
using CollegeManagement.Web.Models;
using CollegeManagement.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CollegeManagement.Web.Extensions;
using CollegeManagement.Web.ViewModels;
using CollegeManagement.Web.Mappers;
using CollegeManagement.Infrastructure.Repositories;

namespace CollegeManagement.Web.Controllers;
public class StudentsController : Controller
{
    private readonly CollegeDbConext db;
    private readonly StudentsRepository studentsRepository;
    private readonly MajorsRepository majorsRepository;

    public StudentsController(CollegeDbConext _db, StudentsRepository _studentsRepository, MajorsRepository majorsRepository)
    {
        db = _db;
        studentsRepository = _studentsRepository;
        this.majorsRepository = majorsRepository;
    }

    public async Task<IActionResult> Index(string searchText = "")
    {
        var students = await studentsRepository.GetAll(searchText);
        var studentViewModels = students.ToViewModel();

        return View(studentViewModels);
    }

    public async Task<IActionResult> Details(int id)
    {
        var student = await studentsRepository.Get(id);// select * from Students where Id = id
        var studentViewModel = student.ToViewModel();
        return View(studentViewModel);
    }

    public async Task<IActionResult> Add()
    {
        var majorsList = await majorsRepository.GetAll();
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

        student.AvatarPath = avatarPath;
        
        studentsRepository.Insert(student);

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
