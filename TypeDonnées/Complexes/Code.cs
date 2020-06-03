using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes.Complexes_;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string Affichage { get; set; }
        [Mos]
        public string Langue { get; set; }//C'est un CodeId de Code
        //KEY
        [Mos]
        public string NomenclatureId { get; set; }
        [Mos]
        public Nomenclature Nomenclature { get; set; }
        [NotMapped]
        internal string TypeName { get { return "Code"; } }

        //FK
        public List<PersonnePhysique> PersonnePhysiques { get; set; }


    }

    
}
