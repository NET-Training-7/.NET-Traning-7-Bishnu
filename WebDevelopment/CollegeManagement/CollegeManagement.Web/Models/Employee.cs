using CollegeManagement.Web.Enums;

namespace CollegeManagement.Web.Models;
public class Employee: PersonBase
{
    public bool Academic { get; set; }
    public JobTitle JobTitle { get; set; }
    public EducationLevel EducationLevel { get; set; }

    public int DepartmentId { get; set; }
    public Department? Department { get; set; }
}
