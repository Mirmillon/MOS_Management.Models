using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.TypeDonnées.Simple;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MOS_Management.Models.TypeDonnées.Complexes.Complexes_
{
    [Mos]
    public class Nomenclature
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
        [MaxLength(150)]
        public MosUri Uri { get; set; }

        //FK
        public string AgenceId { get; set; }
        internal Agence Agence { get; set; }

        public List<Code> Codes { get; set; }

        //CONSTRUCTEUR
        public Nomenclature()
        {
            Uri = new MosUri();
        }

        //PAS DANS LE MOS
        public DateTime? DateInscription { get; set; }
        //PAS DANS LE MOS
        public DateTime? DateModification { get; set; }
        //PAS DANS LE MOS
        public DateTime? DateSuppression { get; set; }
    }
}
