using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MustacheEnt.DAL;
using MustacheEnt.Models;
using MustacheEnt.ViewModel;

namespace MustacheEnt.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel()
            {
                SettingsList = _context.Settings.ToList(),
                IndexList = _context.Index.ToList(),
                MenuPage = "Home"
            };
            return View(homeVM);
        }

        public IActionResult Contact()
        {
            HomeViewModel homeVM = new HomeViewModel()
            {
                SettingsList = _context.Settings.ToList(),
                MenuPage = "Contact"
                // IndexList = _context.Index.ToList()
            };
            return View(homeVM);
        }

        public IActionResult About()
        {
            HomeViewModel homeVM = new HomeViewModel()
            {
                SettingsList = _context.Settings.ToList(),
                MenuPage = "About",
                AboutFieldsList = _context.About.FirstOrDefault()
            };
            return View(homeVM);
        }

        

       


    }
}
