using Microsoft.AspNetCore.Mvc;
using CollegeManagement.Web.Models;
using CollegeManagement.Web.Data;
using F = System.IO.File;

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
        if(student == null || !ModelState.IsValid)
            return View("Error", new ErrorViewModel { RequestId = "Register Student" });

        //Save avatar to phyical folder
        var image = student.Avatar;
        var fileName = $"{Guid.NewGuid()}_{image.FileName}"; //4ea9773c-e77e-4c3c-a075-c97dcffee0fe_My Photo.jpg
        var appFolder = Directory.GetCurrentDirectory();
        var imageFolderPathRelative = $"/images/profiles/{fileName}";
        var imageFolderPathAbsolute = appFolder + "/wwwroot/" + imageFolderPathRelative;

        var avatar = F.Create(imageFolderPathAbsolute);
        image.CopyTo(avatar);
        avatar.Close();

        student.AvatarPath = imageFolderPathRelative;
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
