using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.OrganisationDossier
{
    public class Organisation_Activite
    {
        public string OrganisationInterneId { get; set; }
        public OrganisationInterne OrganisationInterne { get; set; }

        public string ActiviteOperationelleId { get; set; }
        public ActiviteOperationnelle ActiviteOperationelle { get; set; }
    }
}
