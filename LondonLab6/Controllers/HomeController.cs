using LondonLab6.Data;
using LondonLab6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LondonLab6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public HomeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext= applicationDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            _applicationDbContext.Users.Add(user);
            _applicationDbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}