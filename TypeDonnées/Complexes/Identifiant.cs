using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.TypeDonnées.Complexes.Complexes_;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Chaîne de caractères qui, associée à d'autres informations complémentaires, est utilisée 
//pour identifier et différencier d'une manière unique, une instance d'un objet dans une structure de données, des autres objets de la même structure.

namespace MOS_Management.Models.TypeDonnées.Complexes
{
    [Mos]
    public class Identifiant
    {
        [Mos]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string  IdentifiantId { get; set; }
        [Required]
        public string Valeur { get; set; }
        [Mos]
        public Qualification Qualification { get; set; } //DataSet
        [NotMapped]
        internal string TypeName { get { return "Identifiant"; } }

        public string MosSystemId { get; set; }
        public MosSystem MosSystem { get; set; }

        public string LieuId { get; set; }
        public Lieu Lieu { get; set; }


    }
}
