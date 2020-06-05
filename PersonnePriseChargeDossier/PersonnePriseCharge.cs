using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.PersonnePriseChargeDossier
{
    public class PersonnePriseCharge : PersonnePhysique
    {
        public IdentifiantPersonnePriseCharge IdentifiantPersonnePriseCharge { get; set; }

        public List<Contact> Contacts { get; set; }

        public List<Adresse> Adresses { get; set; }

        public List<TeleCommunication> TeleCommunications {get; set;}

        public MetaDonnee MetaDonnee { get; set; }
    }
}
