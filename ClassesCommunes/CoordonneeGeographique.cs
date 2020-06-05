using MOS_Management.Models.ClassesCommunes.ClassesCommunes_;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
using MOS_Management.Models.CLassesMos.FromMesure;
using MOS_Management.Models.TypeDonnées.Complexes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.ClassesCommunes
{
    public class CoordonneeGeographique
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CoordonneeGeographiqueId { get; set; }

        public SystemeGeodesique SystemeGeodesique { get; set; }

        public Latitude Latitude { get; set; }

        public DirectionLatitude DirectionLatitude { get; set; }

        public Longitude Longitude { get; set; }

        public DirectionLongitude DirectionLongitude { get; set; }

        public SystemeAltimetrique SystemeAltimetrique { get; set; }

        public Altitude Altitude { get; set; }

        public TypePrecision TypePrecision { get; set; }

        public Numerique Precision { get; set; }

        public MetaDonnee MetaDonnee { get; set; }
        //
        public string LieuId { get; set; }
        public Lieu Lieu { get; set; }


    }
}
