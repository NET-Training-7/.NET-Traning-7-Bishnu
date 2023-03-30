using CollegeManagement.Web.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CollegeManagement.Web.ViewModels;
public class StudentViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "We need your name."),]
    [MinLength(2, ErrorMessage = "At least 2 letters please.")]
    [RegularExpression(@"[A-Za-z ]+", ErrorMessage = "Only alphabets and spaces are allowed.")]
    public string Name { get; set; } = string.Empty;

    public string? Address { get; set; }
    public Sex Gender { get; set; }

    [DisplayName("Date Of Birth")]
    [DataType(DataType.Date)]
    public DateTime? Dob { get; set; }
    public string Contact { get; set; } = string.Empty;
    public string? Email { get; set; }
    public IFormFile? Avatar { get; set; }
    public string? AvatarPath { get; set; }

    [DisplayName("Roll Number")]
    public int RollNo { get; set; }

    [DisplayName("Major")]
    public int MajorId { get; set; }
    public string MajorName { get; set; } = string.Empty;
    public string Program { get; set; } = string.Empty;
    public string Semester { get; set; } = string.Empty;
}
