using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Scheme.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchemeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SchemeController> _logger;

        public SchemeController(ILogger<SchemeController> logger)
        {
            _logger = logger;
        }

    }
}
