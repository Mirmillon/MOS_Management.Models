using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromIdentifiant
{
    public class SystemeGeodesique : Identifiant
    {
        public  string CoordonneeGeographiqueId { get; set; }
        public CoordonneeGeographique CoordonneeGeographique { get; set; }
    }
}
