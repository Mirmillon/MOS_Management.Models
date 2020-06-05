using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOS_Management.Models.CLassesMos.FromDiplome
{
    public class TousDiplomes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ToutDiplomeId { get; set; }
        [MaxLength(12)]
        [Required]
        [Display(Name = "Code Diplome")]
        public string TypeDiplomeId { get; set; }
        [MaxLength(150)]
        [Display(Name = "Diplome")]
        [Required]
        public string Label { get; set; }
        [Display(Name = "Diplome européen")]
        public bool? DiplomeEuropeen { get; set; }
        [Display(Name = "Diplome français")]
        public bool? DiplomeFrancais { get; set; }
        [Display(Name = "Diplome qualifiant")]
        public bool? DiplomeQualifiant { get; set; }


    }
}
