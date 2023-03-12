namespace CollegeManagement.Web.Models;
public class Student
{
    public int Id { get; set; }
    public int RollNo { get; set; }
    public string Name { get; set; }
    public string? Address { get; set; }
    public string Gender { get; set; }
    public DateTime? Dob { get; set; }
    public string Contact { get; set; }
    public string? Email { get; set; }
    public string Major { get; set; }
    public string Semester { get; set; }
}