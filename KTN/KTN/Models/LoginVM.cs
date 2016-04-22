using System.ComponentModel.DataAnnotations;

namespace KTN.Models
{
    public class LoginVM
    {
        [Required]
        [Display(Name = "İstifadəçi adı")]
        [StringLength(30)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(30)]
        [Display(Name = "Şifrə")]
        public string Password { get; set; }
    }
}