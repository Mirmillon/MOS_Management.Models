using MOS_Management.Models.CLassesMos.FromCode;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.ClassesCommunes
{
    public class Zone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ZoneId { get; set; }

        public string Nom { get; set; }

        public TypeZone TypeZone { get; set; }

        public List<DivisionTerritorial> DivisionTerritorials { get; set; }

        public List<Lieu> Lieus { get; set; }

        public MetaDonnee MetaDonnee { get; set; }
    }
}
