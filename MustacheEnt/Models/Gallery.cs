using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MustacheEnt.Models
{
    public class Gallery:BaseEntity
    {
        [Required]
        public int Order { get; set; }
        
        [Required]
        [StringLength(maximumLength:55)]
        public string Src { get; set; }
        
        [Required]
        [StringLength(maximumLength:55)]
        public string FirstTitle { get; set; }
        
        [StringLength(maximumLength:55)]
        public string SecondTitle { get; set; }
        
        [StringLength(maximumLength:1055)]
        public string Desc { get; set; }
    }
}