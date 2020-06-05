


using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
using MOS_Management.Models.StructureDossier;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.Autorisation
{
    public class EquipementMaterielLourdAutorise: RessourceMaterielle
    {
        /*
        Identifiant fonctionnel de l'autorisation ARHGOS de l'EML.
        */
        [MaxLength(20)]
        [Display(Name = "Identifiant ARHGOS")]
        public AutorisationImplantationArhgos AutorisationImplantationArhgos { get; set; }
        /*
        Code définissant l'équipement matériel lourd (EML) soumis à utorisation.
        Nomenclature(s) associée(s) :
        TRE_R272-EquipementMaterielLourd
        */
        [MaxLength(7)]
        [Display(Name = "Equipement lourd")]
        public EquipementMaterielLourd EquipementMaterielLourd { get; set; }
        /*
        Date de l’arrêté d'autorisation pris par le Directeur Général de l’ARS et donné à l'entité juridique (EJ).
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date autorisation")]
        public string DateAutorisationEML { get; set; }
        /*
        Code indiquant le type de renouvellement de l'autorisation de l'EML.
        A = Ancienne autorisation
        N = Nouvelle autorisation
        P = EML périmé, ancienne autorisation
        R = EML remplacé, nouvelle autorisation
        Nomenclature(s) associée(s) :
        TRE_R273-RenouvellementAutorisationEML
        */
        [MaxLength(2)]
        [Display(Name = "Renouvellement")]
        public RenouvellementAutorisationEML RenouvellementAutorisationEML { get; set; }
        /*
        Date de mise en oeuvre. Elle doit être postérieure à la date de l’arrêté autorisation. 
        La mise en oeuvre est déclenchée à la réception par l’ARS du courrier du directeur de l’établissement.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date M.E.O")]
        public string DateMEO { get; set; }
        /*

        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Fin M.E.O")]
        public string DateFinMEO { get; set; }
        /*
        Indicateur de suppression de l'autorisation de l'EML.
        */
        [Display(Name = "Autorisation supprimée")]
        public bool? SuppressionAutorisationEML { get; set; }
        /*
        Marque de l'équipement matériel lourd (EML).
        */
        [MaxLength(30)]
        [Display(Name = "Marque")]
        public string MarqueEML { get; set; }
        /*
        Numéro de série de l'équipement matériel lourd (EML).
        */
        [MaxLength(20)]
        [Display(Name = "Numèro Série")]
        public string NumereSerieEML { get; set; }

        public MetaDonnee MetaDonnee { get; set; }


        public EquipementMaterielLourdAutorise()
        {
            SuppressionAutorisationEML = false;
        }

        //RELATION AUTRE DOSSIER
        public string EntiteJuridiqueId { get; set; }
        public EntiteJuridique EntiteJuridique { get; set; }

        public new string EntiteGeographiqueId { get; set; }
        public new EntiteGeographique EntiteGeographique { get; set; }


    }
}
