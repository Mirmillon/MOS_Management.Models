using MOS_Management.Models.PersonnePriseChargeDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromIdentifiant
{
    public class IdentifiantPersonnePriseCharge : Identifiant
    {
        public string PersonnePriseChargeId { get; set; }
        public PersonnePriseCharge PersonnePriseCharge { get; set; }
    }
}
