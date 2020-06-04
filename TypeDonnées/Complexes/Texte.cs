using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.CLassesMos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.TypeDonnées.Complexes
{
    [Mos]
    public class Texte
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TexteId { get; set; }
        public string  Valeur { get; set; }
        public Langue Langue { get; set; }
    }
}
