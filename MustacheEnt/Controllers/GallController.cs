using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MustacheEnt.DAL;
using MustacheEnt.Models;
using MustacheEnt.ViewModel;

namespace MustacheEnt.Controllers
{
    public class GallController : Controller
    {
        private readonly AppDbContext _context;

        public GallController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Gallery()
        {
            HomeViewModel homeVM = new HomeViewModel()
            {
                SettingsList = _context.Settings.ToList(),
                MenuPage = "Gallery",
                Galleries = _context.Galleries.OrderBy(x=>x.Order).Take(9).ToList()
            };
             
            return View(homeVM);
        }
        
        public IActionResult SinglePageGallery(int id)
        {
            Gallery gallery = _context.Galleries.FirstOrDefault(x => x.Id ==id);
            
            if (gallery==null)
            {
                return RedirectToAction("Gallery");
            }
            
            HomeViewModel homeVm = new HomeViewModel()
            {
                SettingsList = _context.Settings.ToList(),
                MenuPage = "Gallery",
                GalleryforDetail = gallery
            };

            // DetailGalleryViewModel detailVM = new DetailGalleryViewModel()
            // {
            //     
            //     gallery = gallery
            // };
            return View(homeVm);
        }
    }
}