using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.ClassesCommunes
{
    public class ConceptCode
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ConceptCodeId { get; set; }
        [Required]
        public string Label { get; set; }

        public List<Code> Codes { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

    }
}
