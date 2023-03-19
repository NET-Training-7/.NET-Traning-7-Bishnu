using CollegeManagement.Web.Data;
using CollegeManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Web.Controllers;
public class MajorsController : Controller
{
    CollegeDbConext db = new CollegeDbConext();

    public ActionResult Index()
    {
        var majors = db.Majors.ToList();
        return View(majors);
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add(Major major)
    {
        try
        {
            db.Majors.Add(major);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    public ActionResult Edit(int id)
    {
        return View();
    }

    [HttpPost]
    public ActionResult Edit(Major major)
    {
        try
        {
            db.Majors.Update(major);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    public ActionResult DeleteConfirm(int id)
    {
        return View();
    }

    [HttpPost]
    public ActionResult Delete(Major major)
    {
        try
        {
            db.Majors.Remove(major);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
