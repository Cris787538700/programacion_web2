using System.ComponentModel.DataAnnotations;  
namespace WebAppFerreteria.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string NombreUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }
    }
}
