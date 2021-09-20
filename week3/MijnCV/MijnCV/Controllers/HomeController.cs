using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MijnCV.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MijnCV.Controllers
{
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

        public IActionResult Projecten()
        {

            //Hier komt dadelijk de code om iets uit een DB te halen
            List<Project> projecten = new List<Project>();
            projecten.Add(new Project() { Naam = "Webdictaat", Start = new DateTime(2016, 01, 01), Einde = new DateTime(2019, 01, 01) });

            return View(projecten); //makkelijker
        }

        public IActionResult Kennis()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
