﻿using Microsoft.AspNetCore.Mvc;
using CollegeManagement.Web.Models;
using CollegeManagement.Web.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        db.Students.Add(student);
        db.SaveChanges();

        return RedirectToAction("Index");
    }
}
