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
        public Code Autorite  { get; set; }
        public Code TypeAutorite { get; set; }
        public Identifiant IdNatstruct { get; set; }

        [NotMapped]
        public  string TypeName { get { return this.GetType().ToString(); } }
    }
}
