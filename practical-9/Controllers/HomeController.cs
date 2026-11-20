using Microsoft.AspNetCore.Mvc;
using PlacementDashboard.Models;
using PlacementDashboard.Services;
using practical_9.Models;
using System.Diagnostics;
namespace PlacementDashboard.Controllers;
public class HomeController : Controller
{
    private readonly PlacementDashboardService _dashboardService;
    public HomeController(PlacementDashboardService dashboardService)
    {
        _dashboardService = dashboardService;
    }
    public IActionResult Index()
    {
        return View(_dashboardService.GetDashboard());
    }
    public IActionResult Companies()
    {
        return View(_dashboardService.GetCompanies());
    }
    public IActionResult Report()
    {
        return View(_dashboardService.GetDashboard());
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore
    = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ??
        HttpContext.TraceIdentifier
        });
    }
}