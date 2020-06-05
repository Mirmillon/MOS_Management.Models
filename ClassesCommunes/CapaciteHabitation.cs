using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.ClassesCommunes
{
    public class CapaciteHabitation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string  CapaciteHabitationId { get; set; }
        /*
        Le type d’habitation renseigne sur la taille et le nombre de pièces d’un logement.
        Nomenclature(s) associée(s) :
        TRE_R242-TypeHabitation
        */
        [MaxLength(2)]
        [Display(Name = "Type Habitation")]
        public string TypeHabitationId { get; set; }

        [Display(Name = "Nb Habitation")]
        public short?  NbHabitation { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //
        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }

    }
}
