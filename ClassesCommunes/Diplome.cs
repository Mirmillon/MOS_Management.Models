using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.ProfessionnelDossier;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.ClassesCommunes
{
    public class Diplome
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string DiplomeId { get; set; }

        public TypeDiplome TypeDiplome { get; set; }

        public LieuFormation LieuFormation { get; set; }

        public DateTime DateDiplome { get; set; }

        public string NumeroDiplome { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //
        public string ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; set; }
    }
}
