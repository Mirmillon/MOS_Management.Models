using MOS_Management.Models.AccordDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class DisciplineAutorisation : Code
    {
        public string AutorisationExerciceId { get; set; }
        public AutorisationExercice AutorisationExercice { get; set; }
    }
}
