using System.ComponentModel.DataAnnotations;

namespace MiseEnPratiqueASP.Models
{
#nullable disable
    public class LoginValidation
    {
        [Required(ErrorMessage = "Le champ Email est requis.")]
        [EmailAddress(ErrorMessage = "Veuillez entrer une adresse email valide.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Le champ Mot de passe est requis.")]
        [DataType(DataType.Password)]
        public string Pwd { get; set; }
    }
}
