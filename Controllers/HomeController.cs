using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myMvcApp.Models;
using myMvcApp.ViewModels;
using WebAspNet.ViewModels;
namespace myMvcApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Xinchao()
    {
        return View();
    }

    // GET: /Home/Register
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    // POST: /Home/Register
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(StudentViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        return View("Result", model);
    }

    // Optional GET for Result; accepts model from query or share by POST
    [HttpGet]
    public IActionResult Result(StudentViewModel model)
    {
        return View(model);
    }

    public IActionResult BaiTap2()
    {
        var sp = new SanPhamViewModel
            {
                TenSp = "Kiếm Thần Thoại",
                GiaTien = 150000,
                AnhMoTa = "data:image/jpeg;base64,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"
        
            };

            return View(sp);
    }

    public IActionResult Student()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
