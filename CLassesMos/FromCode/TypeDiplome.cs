using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class TypeDiplome: Code
    {
        public string DiplomeId { get; set; }
        public Diplome Diplome { get; set; }
    }
}
