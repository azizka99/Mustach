using System.ComponentModel.DataAnnotations;

namespace MustacheEnt.Models
{
    public class Index:BaseEntity
    {
        [Required]
        [StringLength(maximumLength:50)]
        public string MainPicSrc { get; set; }
        
        [Required]
        [StringLength(maximumLength:150)]
        public string MainPicsTextTitle { get; set; }
        
        
        [StringLength(maximumLength:255)]
        public string MainPicsTextBody1 { get; set; }
        
        [StringLength(maximumLength:255)]
        public string MainPicsTextBody2 { get; set; }
        
        [StringLength(maximumLength:255)]
        public string MainPicsTextBody3 { get; set; }
        
        [Required]
        [StringLength(maximumLength:55)]
        public string MainPicsTextButton { get; set; }
        
        [StringLength(maximumLength:55)]
        public string LeftPicSrc { get; set; }
        
        [StringLength(maximumLength:55)]
        public string LeftPicTitleText { get; set; }
        
        [StringLength(maximumLength:55)]
        public string CenterPicSrc { get; set; }
        
        [StringLength(maximumLength:55)]
        public string CenterPicTitleText { get; set; }
        
        [StringLength(maximumLength:55)]
        public string RightPicSrc { get; set; }
        
        [StringLength(maximumLength:55)]
        public string RightPicTitleText { get; set; }
        
    }
}