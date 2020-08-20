using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HeaderValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        //private static readonly List<Employee> employees = new List<Employee>()
        //{
        //    new Employee{ EmpId = 1, Name = "Harry"},
        //    new Employee{ EmpId = 2, Name = "Smith"},
        //    new Employee{ EmpId = 3, Name = "Sankar"}
        //};

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //[ActionName("GetCSV")]
        //[Route("getCSV")]
        //[HttpGet]
        //public async Task<IActionResult> CSV() 
        //{
        //    var builder = new StringBuilder();
        //    builder.AppendLine("EmpId,EmpName");
        //    foreach (var emp in employees)
        //    {
        //        builder.AppendLine($"{emp.EmpId} , {emp.Name}");
        //    }

        //    return File(Encoding.UTF8.GetBytes(builder.ToString()), "application/octet-stream", "EmployeeData.csv");
        //}
    }
}
