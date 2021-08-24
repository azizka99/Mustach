using System.ComponentModel.DataAnnotations;

namespace MustacheEnt.Models
{
    public class AboutFields:BaseEntity
    {
        [Required]
        [StringLength(maximumLength:55)]
        public string Title  {get; set;}
        
        [StringLength(maximumLength:55)]
        public string PicSrc {get; set;}
        
        [StringLength(maximumLength:55)]
        public string Header1 {get; set;}
        
        [StringLength(maximumLength:1055)]
        public string Decr1 {get; set;}
        
        [StringLength(maximumLength:55)]
        public string Header2 {get; set;}
        
        [StringLength(maximumLength:1055)]
        public string Decr2 {get; set;}
        
        [StringLength(maximumLength:55)]
        public string Header3 {get; set;}
        
        [StringLength(maximumLength:1055)]
        public string Decr3 {get; set;}
        
        [StringLength(maximumLength:55)]
        public string Header4 {get; set;}
        
        [StringLength(maximumLength:55)]
        public string Decr4 {get; set;}
        
        
    }
}