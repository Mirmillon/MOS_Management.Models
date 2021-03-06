﻿using MOS_Management.Models.OrganisationDossier;
using MOS_Management.Models.StructureDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class TypeFermeture : Code
    {
        public string EntiteJuridiqueId { get; set; }
        public EntiteJuridique EntiteJuridique { get; set; }

        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }

        public string OrganisationInterneId { get; set; }
        public OrganisationInterne OrganisationInterne { get; set; }
    }
}
