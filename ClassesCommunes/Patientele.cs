
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOS_Management.Models.ClassesCommunes
{
    public class Patientele
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PatienteleId { get; set; }

        public Mesure AgeMin { get; set; }

        public Mesure AgeMax { get; set; }

        public CategorieAge CategorieAge { get; set; }

        public PublicPrisEnCharge PublicPrisEnCharge { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //

    }
}
