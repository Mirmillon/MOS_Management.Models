using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos;
using MOS_Management.Models.TypeDonnées.Simple;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.TypeDonnées.Complexes
{
    public class LangueParlee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string LangueParleeId { get; set; }
       
        [NotMapped]
        public MosDateTime MosDateTime { get; set; }
        //Date à laquelle la personne renonce à être référent de cette langue.
        [Display(Name = "Date de fin de référent")]
        public string Date { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        public LangueParlee()
        {
            
        }
        //FK
        public string PersonnePhysiqueId { get; set; }
        public PersonnePhysique PersonnePhysique { get; set; }
      
        public Langue Langue { get; set; }

    }
}
