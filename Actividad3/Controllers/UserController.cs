using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Actividad3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Sergio", "Nicolas", "Jairo", "Diana", "Alex", "Kelly", "Raul", "Deisy", "Maria", "Andres"
        };

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new User
            {
                Date = DateTime.Now.AddDays(index),
                Edad = rng.Next(-20, 55),
                Nombre = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
