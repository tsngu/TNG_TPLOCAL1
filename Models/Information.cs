using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Information
    {
        // Informations personnelles avec REQUIRED aux champs obligatoires.
        [Required(ErrorMessage = "Le nom est requis.")]
        public string? Nom { get; set; }

        [Required(ErrorMessage = "Le prénom est requis.")]
        public string? Prenom { get; set; }

        [Required(ErrorMessage = "Le genre est requis.")]
        public string? Genre { get; set; }

        [Required(ErrorMessage = "L'adresse est requise.")]
        public string? Adresse { get; set; }

        [Required(ErrorMessage = "Le code postal est requis.")]
        public int CodePostal { get; set; }

        [Required(ErrorMessage = "La ville est requise.")]
        public string? Ville { get; set; }

        [Required(ErrorMessage = "L'email est requis.")]
        public string? Email { get; set; }
    }
}
