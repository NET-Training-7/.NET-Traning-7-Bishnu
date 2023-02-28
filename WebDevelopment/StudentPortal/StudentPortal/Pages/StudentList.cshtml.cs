using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentPortal.Pages
{
    public class StudentListModel : PageModel
    {
        public List<Student> Students;


        public void OnGet()
        {
            var s1 = new Student { Name = "Roshan Twayana", RollNo = 353, Contact = "98933424234", Major = "Science", Semester = "III" };
            var s2 = new Student { Name = "Roshan Shrestha", RollNo = 23353, Contact = "9851342434", Major = "Arts", Semester = "II" };
            var s3 = new Student { Name = "Samuel Gurung", RollNo = 10353, Contact = "9893389234", Major = "Education", Semester = "IV" };
            var s4 = new Student { Name = "Roshan Twayana", RollNo = 34353, Contact = "981024234", Major = "Science", Semester = "VI" };
            Students = new List<Student> { s1, s2, s3, s4 };
        }
    }

    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        public string Contact { get; set; }
        public string Semester { get; set; }
    }
}
