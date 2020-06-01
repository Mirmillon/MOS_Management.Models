using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.TypeDonnées.Simple;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.TypeDonnées.Complexes.Complexes_
{
    [Mos]
    public class MosSystem
    {
        [Mos]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string NomenclatureId { get; set; }
        [Mos]
        [Required]
        [MaxLength(150)]
        public string Nom { get; set; }
        [Mos]
        [MaxLength(15)]
        [Mos]
        public string Version { get; set; }
        public MosUri Uri { get; set; }

        //FK
        internal string AgenceId { get; set; }
        internal Agence Agence { get; set; }
    }
}
