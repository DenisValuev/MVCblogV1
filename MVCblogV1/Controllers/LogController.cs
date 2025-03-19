using Microsoft.AspNetCore.Mvc;
using MVCblogV1.Models.db;
using MVCblogV1.Models.Repository;
using System.Reflection.Metadata;

namespace MVCblogV1.Controllers
{
    public class LogController : Controller
    {
        private readonly ILogRepository _logger;

        public LogController(ILogRepository logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Logs()
        {
            var valueUrl = HttpContext.Items["url"] as string;
            if (HttpContext.Items.TryGetValue("CurrentDateTime", out var dateTimeObject))
            {
                DateTime valueDate = (DateTime)dateTimeObject;
                // Добавим создание нового лога
                var newRequest = new Request()
                {
                    Id = Guid.NewGuid(),
                    Date = valueDate,
                    Url = valueUrl
                };
                await _logger.Log(newRequest);
            }

            var Logs = await _logger.GetLogs();
            return View(Logs);
        }
    }
}
