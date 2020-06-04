using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class Ucum :Code
    {
        public string MesureId { get; set; }
        public Mesure Mesure { get; set; }
    }
}
