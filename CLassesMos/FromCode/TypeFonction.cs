using MOS_Management.Models.ProfessionnelDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class TypeFonction : Code
    {
        public string SituationEnExerciceId { get; set; }
        public SituationEnExercice SituationEnExercice { get; set; }
    }
}
