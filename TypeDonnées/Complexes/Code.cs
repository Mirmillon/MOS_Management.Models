using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.TypeDonnées.Complexes.Complexes_;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.TypeDonnées.Complexes
{
    [Mos]
    public class Code
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CodeId  { get; set; }
        [Required]
        public string Affichage { get; set; }
        [Mos]
        public string Langue { get; set; }
        [Mos]
        public string NomenclatureID { get; set; }
        [Mos]
        public Nomenclature Nomenclature { get; set; }
        [NotMapped]
        internal string TypeName { get { return "Code"; } }


    }

    
}
