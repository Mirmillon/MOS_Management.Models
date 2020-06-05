using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.StructureDossier;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.ClassesCommunes
{
    public class DivisionTerritorial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string DivisionTerritorialId { get; set; }

        public TypeDivisionTerritorial TypeDivisionTerritorial { get; set; }

        public CodeDivisionTerritorial CodeDivisionTerritorial { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //
        public string ZoneId { get; set; }
        public Zone Zone { get; set; }

        //
        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }
    }
}
