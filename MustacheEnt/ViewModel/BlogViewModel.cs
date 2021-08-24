using System.Collections.Generic;
using MustacheEnt.Models;

namespace MustacheEnt.ViewModel
{
    public class BlogViewModel
    {
        public List<Settings> SettingsList { get; set; }
        public string MenuPage { get; set; }
        public List<Blog> Blogs { get; set; }
        public Blog SingleBlog { get; set; }
    }
}