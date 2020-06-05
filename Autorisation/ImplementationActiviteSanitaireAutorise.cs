
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
using MOS_Management.Models.StructureDossier;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
Autorisation de la mise en oeuvre d'une activité sanitaire autorisée (détenue par une EJ) dans un
établissement (ou entité géographique (ET)).
*/

namespace MOS_Management.Models.Autorisation
{
    public class ImplementationActiviteSanitaireAutorisee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ImplementationActiviteSanitaireAutoriseeId { get; set; }

        /*
        Identifiant fonctionnel de l'autorisation ARHGOS de l’implantation
        de l'activité sanitaire. Cet identifiant est identique au numéro
        d'autorisation ARHGOS "autorisationActiviteSanitaireArhgos" de
        l'activité sanitaire détenue par l'entité juridique.
        */
        [MaxLength(20)]
        [Display(Name = "Identifiant ARHGOS")]
        public AutorisationImplantationArhgos AutorisationImplantationArhgos { get; set; }
        /*
        Date de mise en oeuvre, elle doit être postérieure ou égale à la
        date de délivrance de l'autorisation de l'activité sanitaire donnée
        à l'entité juridique.
        */

        [Display(Name = "Date Mise En Oeuvre")]
        public string DateMiseEnOeuvre { get; set; }
        /*
        Date de fin de la mise en oeuvre.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Fin Mise En Oeuvre")]
        public string DateFinMiseEnOeuvre { get; set; }
        /*
        Indicateur de suppression de l'autorisation d'implantation de
        l'activité sanitaire.
        */
        [Display(Name = "Suppression autorisation")]
        public bool? SuppressionAutorisation { get; set; }

        public ImplementationActiviteSanitaireAutorisee()
        {
            SuppressionAutorisation = false;
        }

        public MetaDonnee MetaDonnee { get; set; }

        //RELATION DOSSIER
        public string ActiviteSanitaireAutoriseeId { get; set; }
        public ActiviteSanitaireAutorisee ActiviteSanitaireAutorisee { get; set; }

        //RELATION AUTRE DOSSIER
        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }

    }
}
