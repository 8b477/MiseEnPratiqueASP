using System.ComponentModel.DataAnnotations;

namespace MiseEnPratiqueASP.Models
{
#nullable disable

    public class ModelValidationRegisterForm
    {

        [Required(ErrorMessage = "Le champ Nom est requis.")]
        [MinLength(3)]
        public string Nom { get; set; }


        [Required(ErrorMessage = "Le champ Prénom est requis.")]
        [MinLength(3)]
        public string Prenom { get; set; }


        [Required(ErrorMessage = "Le champ Email est requis.")]
        [EmailAddress(ErrorMessage = "Veuillez entrer une adresse email valide.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Le champ Mot de passe est requis.")]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Pwd { get; set; }


        [Required(ErrorMessage = "Le champ Confirmation du mot de passe est requis.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmation du mot de passe")]
        [Compare("Pwd", ErrorMessage = "Les mots de passe ne correspondent pas.")]
        public string Confirmation { get; set; }

    }
}
