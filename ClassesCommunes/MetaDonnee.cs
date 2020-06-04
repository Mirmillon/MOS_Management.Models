using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.CLassesMos.FromTexte;
using MOS_Management.Models.TypeDonnées.Complexes;
using MOS_Management.Models.TypeDonnées.Simple;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Version = MOS_Management.Models.CLassesMos.FromTexte.Version;

namespace MOS_Management.Models.ClassesCommunes
{
    [Mos]
    public class MetaDonnee
    {
      
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string  MetaDonneeId { get; set; }
        public Version Version { get; set; }
        public Commentaire Commentaire { get; set; }
        [NotMapped]
        public MosDateTime CreeLe { get; set; }
        [NotMapped]
        public MosDateTime MajLe { get; set; }
        [NotMapped]
        public MosDateTime TermineLe { get; set; }
        public string  DateCreation { get; set; }
        public string DateMaj { get; set; }
        public string DateFin { get; set; }

        public List<AutoriteEnregistrement> AutoriteEnregistrementS { get; set; }
        public List<Identifiant> Identifiants { get; set; }

        public string TeleCommunicationId { get; set; }
        public TeleCommunication TeleCommunication { get; set; }

        public string AdresseId { get; set; }
        public Adresse Adresse { get; set; }

        public string CapaciteHabitationId { get; set; }
        public CapaciteHabitation CapaciteHabitation { get; set; }

        public string CapaciteAcceuilCriseId { get; set; }
        public CapaciteAcceuilCrise CapaciteAcceuilCrise { get; set; }

        public string CapaciteAcceuilId { get; set; }
        public CapaciteAcceuil CapaciteAcceuil { get; set; }

        public string ConceptCodeId { get; set; }
        public ConceptCode ConceptCode { get; set; }


        [NotMapped]
        public string TypeName { get { return this.GetType().ToString(); } }

        public MetaDonnee()
        {
            CreeLe = new MosDateTime();
            MajLe = new MosDateTime();
            TermineLe = new MosDateTime();
        }

    }
}
