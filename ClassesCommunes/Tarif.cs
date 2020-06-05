using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.StructureDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.ClassesCommunes
{
    public class Tarif
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TarifId { get; set; }

        public TypeTarif TypeTarif { get; set; }

        public Montant Montant { get; set; }

        public UnitePrix UnitePrix { get; set; }

        public string Commentaire { get; set; }

        public DateTime? DateMiseAJour { get; set; }

        public DateTime? DateDebutValidite { get; set; }

        public DateTime? ApplicableDebut { get; set; }

        public DateTime? ApplicableFin { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //
        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }
    }
}
