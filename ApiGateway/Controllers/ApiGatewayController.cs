using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiGatewayController : ControllerBase
    {
        private readonly ILogger<ApiGatewayController> _logger;

        public ApiGatewayController(ILogger<ApiGatewayController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "ApiGateway Up";
        }
    }
}
