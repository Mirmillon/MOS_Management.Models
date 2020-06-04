using EHR_Management.Models.ProjectAttribute;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//classe nom présent dans MOS mais créé à patir de la classe code
namespace MOS_Management.Models.TypeDonnées.Complexes.Complexes_
{
    [Mos]
    public class Agence
    {
        [Mos]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AgenceId { get; set; }
        [Mos]
        [MaxLength(15)]
        public string Acronyme { get; set; }
        [Mos]
        [Required]
        [MaxLength(150)]
        public string Label { get; set; }

        public List<Nomenclature> Nomenclatures { get; set; }
        public List<MosSystem> Systems { get; set; }
    }
}
