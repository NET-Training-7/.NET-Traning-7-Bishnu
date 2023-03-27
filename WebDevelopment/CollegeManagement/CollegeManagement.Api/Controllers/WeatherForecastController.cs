using CollegeManagement.Infrastructure.Repositories;
using CollegeManagement.Infrastructure.Repositories.Interfaces;
using CollegeManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Api.Controllers
{
    [ApiController]
    [Route("api/forecasts")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public WeatherForecastController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public async Task<List<Student>> Get()
        {
            var students = await studentRepository.GetAll();
            return students;
        }
    }
}