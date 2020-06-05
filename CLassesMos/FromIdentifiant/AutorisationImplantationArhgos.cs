using MOS_Management.Models.Autorisation;
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromIdentifiant
{
    public class AutorisationImplantationArhgos: Identifiant
    {
        public string ActiviteSanitaireAutoriseeId { get; set; }
        public ActiviteSanitaireAutorisee ActiviteSanitaireAutorisee { get; set; }

        public string ImplementationActiviteSanitaireAutoriseeId { get; set; }
        public ImplementationActiviteSanitaireAutorisee ImplementationActiviteSanitaireAutorisee { get; set; }

        public string RessourceMaterielleId { get; set; }
        public RessourceMaterielle RessourceMaterielle { get; set; }



    }
}
