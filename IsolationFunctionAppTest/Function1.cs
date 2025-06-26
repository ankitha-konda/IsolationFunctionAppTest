using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http; // For HttpTrigger attribute in isolated worker
using Microsoft.Extensions.Logging;

namespace IsolationFunctionAppTest
{
    /// <summary>
    /// Isolated Azure Function using ASP.NET Core integration pattern.
    /// This function uses HttpRequest and IActionResult from ASP.NET Core
    /// with the isolated worker model for familiar web development experience.
    /// </summary>
    public class Function1
    {
        private readonly ILogger<Function1> _logger;

        public Function1(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        [Function("Function1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
