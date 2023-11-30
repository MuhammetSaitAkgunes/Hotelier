using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Mail adresi boş bırakılamaz !")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz !")]
        public string Password { get; set; }
    }
}
