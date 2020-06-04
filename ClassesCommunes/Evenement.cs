using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.ClassesCommunes
{
    public class Evenement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string EvenementId { get; set; }

        /*
        Code spécifiant le type de l'évènement.
        Nomenclature(s) associée(s) :
        TRE_R254-TypeEvenement
        ASS_A13-TypeEvenement-FluxStandardise
        */
        [MaxLength(3)]
        [Display(Name = "Type Evenement")]
        public string TypeEvenementId { get; set; }

        /*
        Date/heure à laquelle l'évènement est arrivé.
        */
        [Display(Name = "Moment survenu")]
        public DateTime? Occurence { get; set; }
        /*
        */
        [Display(Name = "Moment déclaration")]
        public DateTime? Declaration { get; set; }
        /*
        */
        [Display(Name = "Description")]
        [MaxLength(200)]
        public string  Description { get; set; }
    }
}
