using Microsoft.AspNetCore.Mvc.Filters;
using NLog;
namespace Practica1.Filters
{
    public class ExceptionLoggerFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var logger = LogManager.GetCurrentClassLogger();
            logger.Error(context.Exception);
        }
    }
}
