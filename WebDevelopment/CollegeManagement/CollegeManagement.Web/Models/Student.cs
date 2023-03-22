using CollegeManagement.Web.Enums;
using System.ComponentModel;

namespace CollegeManagement.Web.Models;
public class Student : PersonBase
{
    public int RollNo { get; set; }

    public string Major { get; set; } = string.Empty;
    public string Program { get; set; } = string.Empty;
    public string Semester { get; set; } = string.Empty;
}
