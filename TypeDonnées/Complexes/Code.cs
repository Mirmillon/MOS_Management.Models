using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos;
using MOS_Management.Models.TypeDonnées.Complexes.Complexes_;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading;

namespace MOS_Management.Models.TypeDonnées.Complexes
{
    [Mos]
    public class Code
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CodeId  { get; set; }
        [Required]
        public string Valeur { get; set; }
        [Required]
        [MaxLength(90)]
        public string Affichage { get; set; }
        [MaxLength(90)]
        public string AffichageCourt { get; set; }
        [MaxLength(150)]
        public string AffichageLong { get; set; }
        [Mos]
     
        public string LangueId { get; set; }//C'est un CodeId de Code
        //KEY
        [Mos]
        public string NomenclatureId { get; set; }
        public Nomenclature Nomenclature { get; set; }
        [NotMapped]
        internal string TypeName { get { return "Code"; } set { } }

        //PAS DANS LE MOS
        public DateTime? DateInscription { get; set; }
        //PAS DANS LE MOS
        public DateTime? DateModification { get; set; }
        //PAS DANS LE MOS
        public DateTime? DateSuppression { get; set; }


        public string ConceptCodeId { get; set; }
        public ConceptCode ConceptCode { get; set; }




    }

    
}
