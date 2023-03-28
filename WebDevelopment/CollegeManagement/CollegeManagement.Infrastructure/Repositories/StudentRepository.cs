using CollegeManagement.Infrastructure.Repositories.Interfaces;
using CollegeManagement.Web.Data;
using CollegeManagement.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Infrastructure.Repositories;
public class StudentRepository : IStudentRepository
{
    private readonly CollegeDbConext db;

    public StudentRepository(CollegeDbConext _db)
    {
        db = _db;
    }

    public async Task<List<Student>> GetAll(string searchText = "")
    {
        try
        {
            List<Student> students = new();

            if (searchText == "")
                students = await db.Students.ToListAsync();
            else
                students = await db.Students.Where(x => x.Name.Contains(searchText) ||
                            x.Address.Contains(searchText)).ToListAsync();
            return students;
        }
        catch (Exception ex)
        {
            throw new Exception($"Unable to connect to db. Error: {ex.Message}");
        }
    }

    public async ValueTask<Student> Get(int id)
    {
        var student = await db.Students.FindAsync(id);
        return student;
    }

    public async Task Insert(Student student)
    {
        await db.Students.AddAsync(student);
        await db.SaveChangesAsync();
    }

    public async Task Edit(Student student)
    {
        db.Students.Update(student);
        await db.SaveChangesAsync();
    }

    public async Task Delete (int id)
    {
        await db.Students.Where(x => x.Id == id).ExecuteDeleteAsync();
    }
}
