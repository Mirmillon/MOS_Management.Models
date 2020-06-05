
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
using MOS_Management.Models.StructureDossier;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
/*
Accord conclu entre deux ou plusieurs parties en vue de produire certains effets juridiques : créer
des obligations, modifier ou mettre un terme à des obligations préexistantes.
*/

namespace MOS_Management.Models.AccordDossier
{
    public class Convention
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ConventionId { get; set; }
        /*
        Numéro de la convention.
        */
        [MaxLength(15)]
        [Display(Name ="Numèro Convention")]
        public NumeroConvention NumeroConvention { get; set; }
        /*
        Titre de la convention, par exemple "Convention constitutive du groupement hospitalier de territoire des Bouches du Rhône".
        */
        [MaxLength(300)]
        [Display(Name = "Titre Convention")]
        public string NomConvention { get; set; }
        /*
        */
        [DataType(DataType.Date)]
        [Display(Name = "Début Convention")]
        public DateTime? DebutConvention { get; set; }
        /*
        */
        [DataType(DataType.Date)]
        [Display(Name = "Fin Convention")]
        public DateTime? FinConvention { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //RELATION AUTRE DOSSIER
        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }


    }
}
