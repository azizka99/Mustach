using System.ComponentModel.DataAnnotations;

namespace MustacheEnt.Models
{
    public class Settings:BaseEntity
    {
        [Required]
        [StringLength(maximumLength:50)]
        public string MainLogoSrc { get; set; }
        
        // [Required]
        // [StringLength(maximumLength:35)]
        // public string MainHeader { get; set; }
        
        [Required]
        [StringLength(maximumLength:150)]
        public string MainFooterText { get; set; }
        
        [StringLength(maximumLength:50)]
        public string FooterTwitter { get; set; }
        
        [StringLength(maximumLength:50)]
        public string FooterFacebook { get; set; }
        
        [StringLength(maximumLength:50)]
        public string FooterGoogle { get; set; }
        
        [StringLength(maximumLength:50)]
        public string FooterPrinterest { get; set; }
    }
}