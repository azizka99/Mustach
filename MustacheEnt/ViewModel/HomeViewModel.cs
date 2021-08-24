using System.Collections.Generic;
using MustacheEnt.Models;

namespace MustacheEnt.ViewModel
{
    public class HomeViewModel
    {
        public List<Settings> SettingsList { get; set; }
        public List<Index> IndexList { get; set; }
        public string MenuPage { get; set; }
        public List<Gallery> Galleries { get; set; }
        public  Gallery GalleryforDetail { get; set; }
        public AboutFields AboutFieldsList { get; set; }
    }
}