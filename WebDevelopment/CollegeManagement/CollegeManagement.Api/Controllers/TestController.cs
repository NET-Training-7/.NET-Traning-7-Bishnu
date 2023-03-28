using CollegeManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Greet()
    {
        return "Hello there!!!";
    }

    [HttpGet("greet1")]
    public string Greet1()
    {
        return "Hello there 1!!!";
    }

    [HttpGet("student")]
    public Student GetStudent()
    {
        var student = new Student();

        return student;
    }

    [HttpGet("students")]
    public List<Student> GetStudents()
    {
        var students = new List<Student>() { new Student(), new Student(), new Student() };

        return students;
    }
}
