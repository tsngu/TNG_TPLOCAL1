using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Information
    {
        // Informations personnelles 

        // Required pour les champs obligatoires, sinon message d'erreur.
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

        // Informations formation

        [Required(ErrorMessage = "La date de début de formation est requise.")]
        public string? DateDebutFormation { get; set; }

        [Required(ErrorMessage = "Le type de formation est requis.")]
        public string? TypeFormation { get; set; }

        // Avis sur la formation

        [Required]
        public string? avisFC { get; set; }

        [Required]
        public string? avisFO { get; set; }

    }
}
