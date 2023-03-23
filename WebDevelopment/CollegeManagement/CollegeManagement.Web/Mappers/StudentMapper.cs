using CollegeManagement.Web.Models;
using CollegeManagement.Web.ViewModels;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace CollegeManagement.Web.Mappers;
public static class StudentMapper
{
    public static Student ToModel(this StudentViewModel studentVM) =>
        new Student
        {
            Id= studentVM.Id,
            Name = studentVM.Name,
            Dob = studentVM.Dob,
            Contact = studentVM.Contact,
            Gender = studentVM.Gender,
            Address = studentVM.Address,
            Email = studentVM.Email,
            Major = studentVM.Major,
            Program = studentVM.Program,
            Semester = studentVM.Semester,
            RollNo = studentVM.RollNo
        };

    public static StudentViewModel ToViewModel(this Student student) =>
        new StudentViewModel
        {
            Id= student.Id,
            Name = student.Name,
            Dob = student.Dob,
            Contact = student.Contact,
            Gender = student.Gender,
            Address = student.Address,
            Email = student.Email,
            Major = student.Major,
            Program = student.Program,
            Semester = student.Semester,
            RollNo = student.RollNo,
            AvatarPath= student.AvatarPath
        };

    public static List<StudentViewModel> ToViewModel(this List<Student> students) => 
        students.Select(student => student.ToViewModel()).ToList();
}
