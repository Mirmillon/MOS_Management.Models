using MOS_Management.Models.AccordDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromIdentifiant
{
    public class NumeroLicence : Identifiant
    {
        public string LicenceExploitationId { get; set; }
        public LicenceExploitation LicenceExploitation { get; set; }
    }
}
