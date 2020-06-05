using MOS_Management.Models.ProfessionnelDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromIdentifiant
{
    public class IPS : Identifiant
    {
        public string ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; set; }
    }
}
