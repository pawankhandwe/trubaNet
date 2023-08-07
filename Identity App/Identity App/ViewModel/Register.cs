using System.ComponentModel.DataAnnotations;

namespace Identity_App.NewModel
{
    public class Register
    {
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Password and confirmation password does not match")]
        public string confirmPassword { get; set;}
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
