using CollegeManagement.Web.Data;
using CollegeManagement.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Infrastructure.Repositories;
public class StudentsRepository
{
    private readonly CollegeDbConext db;

    public StudentsRepository(CollegeDbConext _db)
    {
        db = _db;
    }

    public async Task<List<Student>> GetAll(string searchText)
    {
        List<Student> students = new();

        if (searchText == "")
            students = await db.Students.ToListAsync();
        else
            students = await db.Students.Where(x => x.Name.Contains(searchText) ||
                        x.Address.Contains(searchText)).ToListAsync();
        return students;
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
}
