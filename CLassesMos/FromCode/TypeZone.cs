using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class TypeZone : Code
    {
        public string ZoneId { get; set; }
        public Zone Zone { get; set; }
    }
}
