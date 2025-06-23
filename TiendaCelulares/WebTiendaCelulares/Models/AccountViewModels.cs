using System.ComponentModel.DataAnnotations;

namespace WebTiendaCelulares.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Usuario")]
        public string usuario { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string clave { get; set; }
        [Display(Name = "Recordarme")]
        public bool recordarme { get; set; }
    }
}
