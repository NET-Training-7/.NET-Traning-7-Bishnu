using CollegeManagement.Web.Enums;

namespace CollegeManagement.Web.Models;
public class PersonBase
{
    public int Id { get; set; }   
    public string Name { get; set; } = string.Empty;
    public string? Address { get; set; }
    public Sex Gender { get; set; }
    public DateTime? Dob { get; set; }
    public string Contact { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? AvatarPath { get; set; }
}
