using MOS_Management.Models.OrganisationDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class Activite : Code
    {
        public string ActiviteOperationelleId { get; set; }
        public ActiviteOperationnelle ActiviteOperationelle { get; set; }
    }
}
