using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Exam1.Models
{
    public class Invitation
    {
        [Required(ErrorMessage ="E-mail gerekli alandır.")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "isim gerekli alandır.")]
        [DisplayName("Name")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim gerekli alandır.")]
        [DisplayName("SurName")]
        public string? LastName { get; set; }
        public string FullName  => $"{FirstName} {LastName?.ToUpper()}";

        public DateTime ApplyDate { get; set; }

        public int Age { get; set; }
        public string? Gender { get; set; }
        public Invitation()
        {
            ApplyDate = DateTime.Now;
        }
    }
}
