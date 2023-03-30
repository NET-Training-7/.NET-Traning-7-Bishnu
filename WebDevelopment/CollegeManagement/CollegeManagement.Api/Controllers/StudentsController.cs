using CollegeManagement.Infrastructure.Repositories.Interfaces;
using CollegeManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly IStudentRepository studentRepository;

    public StudentsController(IStudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
    }

    [HttpGet]
    public async Task<List<Student>> Get()
    {
        var students = await studentRepository.GetAll();
        return students;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> Get(int id)
    {
        var student = await studentRepository.Get(id);
        if (student is null)
            return NotFound();

        return Ok(student);
    }

    [HttpPost]
    public async Task<ActionResult> Post(Student student)
    {
        await studentRepository.Insert(student);

        return Created($"/api/student/{student.Id}", student);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, Student student)
    {
        student.Id = id;
        await studentRepository.Edit(student);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await studentRepository.Delete(id);

        return NoContent();
    }
}
