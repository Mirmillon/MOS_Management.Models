using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromIdentifiant
{
    public class IdentifiantNationalStructure : Identifiant
    {
        public string AutoriteEnregistrementId { get; set; }
        public AutoriteEnregistrement AutoriteEnregistrement { get; set; }
    }
}
