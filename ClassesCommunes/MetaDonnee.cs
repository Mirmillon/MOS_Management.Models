using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.AccordDossier;
using MOS_Management.Models.CLassesMos.FromTexte;
using MOS_Management.Models.PersonnePriseChargeDossier;
using MOS_Management.Models.ProfessionnelDossier;
using MOS_Management.Models.StructureDossier;
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

        public MetaDonnee()
        {
            CreeLe = new MosDateTime();
            MajLe = new MosDateTime();
            TermineLe = new MosDateTime();
        }

        //
        [NotMapped]
        public string TypeName { get { return this.GetType().ToString(); } }

        //
        public List<AutoriteEnregistrement> AutoriteEnregistrementS { get; set; }

        public List<Identifiant> Identifiants { get; set; }

        //
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

        public string ContactId { get; set; }
        public Contact Contact { get; set; }

        public string CoordonneeGeographiqueId { get; set; }
        public CoordonneeGeographique CoordonneeGeographique { get; set; }

        public string DiplomeId { get; set; }
        public Diplome Diplome { get; set; }

        public string DivisionTerritorialId { get; set; }
        public DivisionTerritorial DivisionTerritorial { get; set; }

        public string EvenementId { get; set; }
        public Evenement Evenement { get; set; }

        public string HoraireId { get; set; }
        public Horaire Horaire { get; set; }

        public string LieuId { get; set; }
        public Lieu Lieu { get; set; }

        public string PatienteleId { get; set; }
        public Patientele Patientele { get; set; }

        public string TarifId { get; set; }
        public Tarif Tarif { get; set; }

        public string TeleCommunicationId { get; set; }
        public TeleCommunication TeleCommunication { get; set; }

        public string ZoneId { get; set; }
        public Zone Zone { get; set; }

        //
        public string ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; set; }

        public string PersonnePriseChargeId { get; set; }
        public PersonnePriseCharge PersonnePriseCharge { get; set; }

        //
        public string AttributionParticuliéreId { get; set; }
        public AttributionParticuliére AttributionParticuliére { get; set; }

        public string ExerciceProfessionnelId { get; set; }
        public ExerciceProfessionnel ExerciceProfessionnel { get; set; }

        public string NiveauFormationId { get; set; }
        public NiveauFormation NiveauFormation { get; set; }

        public string InscriptionOrdreId { get; set; }
        public InscriptionOrdre InscriptionOrdre { get; set; }

        public string SavoirFaireId { get; set; }
        public SavoirFaire SavoirFaire { get; set; }

        public string SituationEnExerciceId { get; set; }
        public SituationEnExercice SituationEnExercice { get; set; }

        public string SituationOperationnelleId { get; set; }
        public SituationOperationnelle SituationOperationnelle { get; set; }

        //AccordDossier
        public string AutorisationExerciceId { get; set; }
        public AutorisationExercice AutorisationExercice { get; set; }

        public string ConventionId { get; set; }
        public Convention Convention { get; set; }

        public string LicenceExploitationId { get; set; }
        public LicenceExploitation LicenceExploitation { get; set; }

        //Structure
        public string EntiteJuridiqueId { get; set; }
        public EntiteJuridique EntiteJuridique { get; set; }

        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }


    }
}
