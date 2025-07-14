using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CustomWebApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            string logMessage = $"{DateTime.Now}: {exception.Message}\n{exception.StackTrace}\n";
            var logPath = Path.Combine(Directory.GetCurrentDirectory(), "errorlog.txt");
            File.AppendAllText(logPath, logMessage);

            context.Result = new ObjectResult("An unexpected error occurred.")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}

