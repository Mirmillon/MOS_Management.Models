
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
Eléments permettant de retrouver les informations d'inscription à un ordre par rapport à 
la profession de la personne physique sur une période et un département donné
Synonymes RPPS : Inscription à ordre 
*/

namespace MOS_Management.Models.ProfessionnelDossier
{
    public class InscriptionOrdre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string InscriptionOrdreId { get; set; }

        /*
        Instance de régulation d'une profession de santé réglementée.
        Nomenclature(s) associée(s) :
        TRE_R82-Ordre
        */
        [MaxLength(6)]
        [Display(Name = "Type Ordre")]
        public string TypeOrdreProfessionelId { get; set; }

        /*
        Date d’inscription de la personne au tableau de l’ordre.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Inscription")]
        public DateTime? DateDebut { get; set; }

        /*
         Fin d’inscription de la personne au tableau de l’ordre.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Radiation")]
        public DateTime? DateRadiation { get; set; }

        /*
        Information indiquant l’avancement du traitement du dossier d'inscription de la personne.
        Nomenclature(s) associée(s) :
        TRE_R33-StatutInscription
        */
        [MaxLength(1)]
        [Display(Name = "Statut inscription")]
        public string StatutInscriptionId { get; set; }

        /*
        */
        [MaxLength(6)]
        [Display(Name = "Département inscription")]
        public string CodeDepartementId { get; set; }


       

    }
}
