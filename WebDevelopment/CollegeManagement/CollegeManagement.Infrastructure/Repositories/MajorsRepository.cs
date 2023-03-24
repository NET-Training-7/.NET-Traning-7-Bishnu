using CollegeManagement.Web.Data;
using CollegeManagement.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Infrastructure.Repositories;
public class MajorsRepository
{
    private readonly CollegeDbConext db;

    public MajorsRepository(CollegeDbConext _db)
    {
        db = _db;
    }

    public async Task<List<Major>> GetAll()
    {
        List<Major> majors = await db.Majors.ToListAsync();        
        return majors;
    }
}
