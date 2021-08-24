using System.ComponentModel.DataAnnotations;

namespace MustacheEnt.Models
{
    public class Blog:BaseEntity
    {
        [Required]
        [StringLength(maximumLength:200)]
        public string PicSrc { get; set; }
        
        [Required]
        [StringLength(maximumLength:200)]
        public string Title { get; set; }
        
        [StringLength(maximumLength:10000)]
        public string Desc { get; set; }
        
        [StringLength(maximumLength:2000)]
        public string FrontDesc { get; set;  }
    }
}