using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
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
    }
}
