using MOS_Management.Models.ProfessionnelDossier;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.PersonnePriseChargeDossier
{
    public class PersonnePriseEnCharge_Professionnel
    {
        public string ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; set; }

        public string PersonnePriseChargeId { get; set; }
        public PersonnePriseCharge PersonnePriseCharge { get; set; }
    }
}
