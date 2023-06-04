using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BK.Models;
using BK.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;

namespace BangkokWheels.Controllers;

[Area("Customer")]
[AllowAnonymous]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        IEnumerable<Car> carList = _unitOfWork.Car.GetAll(includeProperties: "CarSpecification,Brand");

        return View(carList);
    }

    public IActionResult Details(int carId)
    {
        Car car = _unitOfWork.Car.Get(u => u.Id == carId, includeProperties: "CarSpecification,Brand");

        return View(car);
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

