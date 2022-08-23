using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Notification.Core.Services.Contracts;
using Notification.Web.Models;

namespace Notification.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly INotificationService _notificationService;

    public HomeController(ILogger<HomeController> logger, INotificationService notificationService)
    {
        _logger = logger;
        _notificationService = notificationService;
    }

    public IActionResult Index()
    {
        _notificationService.Success("Success message from index page!");
        return View();
    }

    public IActionResult Privacy()
    {
        _notificationService.Success("Success message - 1 from privacy page!");
        _notificationService.Success("Success message - 2 from privacy page!");
        _notificationService.Success("Success message - 3 from privacy page!");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}