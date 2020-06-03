using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.TypeDonnées.Complexes;
using MOS_Management.Models.TypeDonnées.Simple;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.ClassesCommunes
{
    [Mos]
    public class MetaDonnee
    {
        public MetaDonnee()
        {
            CreeLe = new MosDateTime();
            MajLe = new MosDateTime();
            TermineLe = new MosDateTime();
        }



        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MetaDonneeId { get; set; }
        public string Version { get; set; }
        public string Commentaire { get; set; }
        [NotMapped]
        public MosDateTime CreeLe { get; set; }
        [NotMapped]
        public MosDateTime MajLe { get; set; }
        [NotMapped]
        public MosDateTime TermineLe { get; set; }
        public string  DateCreation { get; set; }
        public string DateMaj { get; set; }
        public string DateFin { get; set; }
        //FK
        public string AutoriteEnregistrementId { get; set; }
        public AutoriteEnregistrement AutoriteEnregistrement { get; set; }
        public string IdentifiantId { get; set; }
        public Identifiant Identifiant { get; set; }



        [NotMapped]
        public string TypeName { get { return this.GetType().ToString(); } }

    }
}
