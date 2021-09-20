using KleineDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KleineDemo.Controllers
{
    public class HeroesController : Controller
    {
        private MyContext _database; 

        public HeroesController(MyContext context)
        {
            this._database = context;

        }

        public IActionResult Index()
        {        
            return View(_database.Heroes.ToList());
        }

        public IActionResult Show(String id)
        {
            Hero hero = _database.Heroes
                .Include("MyWeapons")
                .FirstOrDefault(h => h.Id == id);

            return View(hero);
        }
    }
}
