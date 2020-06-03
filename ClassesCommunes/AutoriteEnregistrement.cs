using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.ClassesCommunes
{
    [Mos]
    public  class AutoriteEnregistrement
    {
        [Mos]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AutoriteEnregistrementId { get; set; } 
        [Required]
        public string ValeurAutoriteEnregistrement { get; set; } //C'est un codeId de Code

        [Mos]
        public Code TypeAutorite { get; set; }
        [Mos]
        public Identifiant IdentifiantNationalStructure { get; set; }

        [NotMapped]
        public string TypeName { get { return this.GetType().ToString(); } }

        //FK
        public List<MetaDonnee> MetaDonnees { get; set; }
    }
}
