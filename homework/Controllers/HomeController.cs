using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using homework.Models;
using homework.Services.Interfaces;

namespace homework.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITimeService timeService;
    private readonly IRandomNumberService randomNumberService;
    private readonly IAddVisit addVisit;
    private readonly IVisits visits;
    private FileStream file;
    private StreamReader reader;

    public HomeController(ILogger<HomeController> logger, IAddVisit addVisit, IVisits visits, ITimeService timeService, IRandomNumberService randomNumberService)
    {
        _logger = logger;

        this.timeService = timeService;
        this.randomNumberService = randomNumberService;
        this.addVisit = addVisit;
        this.visits = visits;
    }

    public void UseAddVisitService()
    {
        addVisit.AddingVisit(new FileStream("visits.txt", FileMode.Append));
    }
    public string UseViewingVisitsService()
    {
        return visits.ViewingVisits(new StreamReader("visits.txt"));
    }
    public string UseTimeService()
    {
        return timeService.GetCurrentTime();
    }

    public string UseRandomNumberService()
    {
        return randomNumberService.GetRandomNumber();
    }

    public IActionResult Index()
    {
        UseAddVisitService();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
