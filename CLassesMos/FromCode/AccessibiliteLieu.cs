﻿using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.StructureDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class AccessibiliteLieu : Code
    {
        public string LieuId { get; set; }
        public Lieu Lieu { get; set; }

        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }
    }
}
