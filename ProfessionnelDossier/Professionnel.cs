using MOS_Management.Models.AccordDossier;
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
using MOS_Management.Models.PersonnePriseChargeDossier;
using System.Collections.Generic;

namespace MOS_Management.Models.ProfessionnelDossier
{
    public class Professionnel :PersonnePhysique
    {
        public IPP IPP { get; set; }

        public TypeIdentifiantNationalPersonnePhysique TypeIdentifiantNationalPersonnePhysique { get; set; }

        public IPS IPS { get; set; }

        public List<Diplome> Diplomes { get; set; }

        public List<Adresse> Adresses { get; set; }

        public List<TeleCommunication> TeleCommunications { get; set; }

        public List<BoileLettreMMS> BoileLettreMMSs { get; set;  }

        public MetaDonnee MetaDonnee { get; set;  }

        //RELATION DOSSIER PROFESSIONNEL D'APRES SCHEMA
        public List<ExerciceProfessionnel> ExerciceProfessionnels { get; set; }

        public List<PersonnePriseEnCharge_Professionnel> Soignant_Soigne { get; set; }

        //RELATION AVEC LES AUTRES DOSSIERS
        public List<AutorisationExercice> AutorisationExercices { get; set; }
    }
}
