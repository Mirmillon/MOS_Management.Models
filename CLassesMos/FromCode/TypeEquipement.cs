using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.OrganisationDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class TypeEquipement : Code
    {
        public string EquipementOperationnelleId { get; set; }
        public EquipementOperationnelle EquipementOperationnelle { get; set; }
    }
}
