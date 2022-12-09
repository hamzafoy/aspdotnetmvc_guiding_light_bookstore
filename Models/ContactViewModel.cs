using System.ComponentModel.DataAnnotations;

namespace SampleNetCoreMVC.Models
{
    public class ContactViewModel
    {
        //You can set custom error messages to return to a 'div' with asp-validation-summary
        //[Required(ErrorMessage ="A full name is required")]
        [Required]
        [MinLength(3)]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string MessageSubject { get; set; }
        [Required]
        [MaxLength(500)]
        public string MessageBody { get; set; }
    }
}
