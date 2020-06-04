
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
La capacité en situation de crise représente le nombre de places supplémentaires, par rapport à la
capacité théorique usuelle, que l’établissement peut mettre à disposition pour accueillir des
patients lors du déclenchement du plan ORSAN, en fonction du délai.
*/

namespace MOS_Management.Models.ClassesCommunes
{
    public class CapaciteAcceuilCrise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CapaciteAcceuilCriseId { get; set; }
        /*
        La capacité en situation de crise T0 représente le nombre de places supplémentaires, par rapport à la capacité théorique usuelle, 
        que l’établissement peut mettre à disposition pour accueillir des patients lors du déclenchement du plan ORSAN. 
        La capacité en places correspond à tout ce qui est utilisable (lit, brancard) pour accueillir un patient allongé.
        */
        [Display(Name = "Capacité T0")]
        public short? CapaciteT0 { get; set; }
        /*
        */
        [Display(Name = "Capacité T60")]
        public short? CapaciteT60 { get; set; }

        public MetaDonnee MetaDonnee { get; set; }


    }
}
