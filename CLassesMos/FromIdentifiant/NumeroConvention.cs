using MOS_Management.Models.AccordDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromIdentifiant
{
    public class NumeroConvention : Identifiant
    {
       
        public string ConventionId { get; set; }
        public Convention Convention { get; set; }
    }
}
