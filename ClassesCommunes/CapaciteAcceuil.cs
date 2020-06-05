using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
lien O 1
Une entite a ouu n'a pas de capapcite d'acceuil
*/
namespace MOS_Management.Models.ClassesCommunes
{
    public class CapaciteAcceuil
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string  CapaciteAcceuilId { get; set; }
        /*
        Année N-1 citée comme année de référence pour les lits et places
        installés, en état d'accueillir des patients, y compris ceux et celles
        fermés temporairement pour cause de travaux (attributs
        nbLitsInstalles et nbPlacesInstallees)
        */
        [Display(Name ="Année réféence")]
        [MaxLength(4)]
        public string AnneeReference { get; set; }
        /*
        Il s’agit des lits installés en état d’accueillir des patients, y compris ceux fermés temporairement pour cause de travaux.
        */
        [Display(Name = "Nombre lits installés")]
        public short? NbLitssInstalles { get; set; }
        /*
        Il s’agit des places installées en état d’accueillir des patients, y compris celles fermées temporairement pour cause de travaux.
        */
        [Display(Name = "Nombre places installées")]
        public short? NbPlacesInstalles { get; set; }
        /*

        */
        [Display(Name = "Nombre lits disponibles")]
        public short? NbLitsDisponibles { get; set; }
        /*

        */
        [Display(Name = "Nombre places disponibles")]
        public short? NbPlacesDisponibles { get; set; }

        [Display(Name = "Nombre chambres individuelless")]
        public short? NbChambresIndividuelles { get; set; }

        [Display(Name = "Nombre chambres individuelles disponibles")]
        public short? NbChambresIndividuellesDisponibles { get; set; }


        [Display(Name = "Nombre chambres doubles")]
        public short? NbChambresDoubles { get; set; }

        [Display(Name = "Nombre chambres doubles disponibles")]
        public short? NbChambresDoublesDisponibles { get; set; }

        /*
        Date de mise à jour du nombre des places disponibles.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date mises à jour pour les places")]
        public DateTime? DateMajPlacesDisponibles { get; set; }

        /*
        Date de mise à jour du nombre de chambes disponibles.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date mises à jour pour les chambres")]
        public DateTime? DateMajChambresDisponibles { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //
        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }


    }
}
