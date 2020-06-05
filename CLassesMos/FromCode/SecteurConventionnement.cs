using MOS_Management.Models.ProfessionnelDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class SecteurConventionnement : Code
    {
        public string SituationOperationnelleId { get; set; }
        public SituationOperationnelle SituationOperationnelle { get; set; }
    }
}
