using MOS_Management.Models.ProfessionnelDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class NatureFormation : Code
    {
        public string NiveauFormationId { get; set; }
        public NiveauFormation NiveauFormation { get; set; }
    }
}
