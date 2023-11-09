using System.ComponentModel.DataAnnotations;

namespace WebApp01.Models
{
    public class Contact
    {
        [Display (Name= "Name")]
        [Required(ErrorMessage="Field is required")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "Field is required")]
        public string Surname { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Field is required")]
        public int Age { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Field is required")]
        public string Email { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage = "Field is required")]
        [StringLength(30, ErrorMessage="Minimal 30 symbols")]
        public string Message { get; set; }


    }
}
