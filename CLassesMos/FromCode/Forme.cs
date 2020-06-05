using MOS_Management.Models.Autorisation;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class Forme : Code
    {
        public string ActiviteSanitaireAutoriseeId { get; set; }
        public ActiviteSanitaireAutorisee ActiviteSanitaireAutorisee { get; set; }
    }
}
