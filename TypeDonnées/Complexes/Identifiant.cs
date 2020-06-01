using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.TypeDonnées.Complexes.Complexes_;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.TypeDonnées.Complexes
{
    [Mos]
    public class Identifiant
    {
        [Mos]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string  IdentifiantId { get; set; }
        [Mos]
        public Code Code { get; set; } //DataSet
        [Mos]
        public MosSystem System { get; set; }
        [NotMapped]
        internal string TypeName { get { return "Identifiant"; } }



    }
}
