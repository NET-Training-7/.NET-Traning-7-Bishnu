using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentPortal.Pages
{
    public class StudentListModel : PageModel
    {
        public List<Student> Students { get; set; }
        public void OnGet()
        {
            Students = new List<Student>
            {
                new Student { Name = "Bishnu" },
                new Student { Name = "Bishnu" },
                new Student { Name = "Bishnu" }
            };
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
