

using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
Prérogatives d'exercice d'un professionnel reconnues par une autorité d'enregistrement sur une période donnée de son exercice professionnel, 
par exemple les spécialités ordinales, etc.
Mise en correspondance FHIR R4: PractitionerRole (specialty)
*/

namespace MOS_Management.Models.ProfessionnelDossier
{
    public class SavoirFaire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SavoirFaireId { get; set; }

        /*
        Le type de savoir-faire (qualifications/autres attributions) désigne par exemple:
        ** une spécialité ordinale (S);
        ** une compétence (C);
        ** etc.
        Nomenclature(s) associée(s) :
        TRE_R04-TypeSavoirFaire
        */
        [Display(Name = "Type Savoir Faire")]
        public TypeSavoirFaire TypeSavoirFaire { get; set; }

        //Date à laquelle, l’organisme donnant l’autorisation d’exercer une qualification 
        //a reconnu cette qualification ou date à laquelle l'attribution a été donnée au professionnel
        [DataType(DataType.Date)]
        [Display(Name ="Date Reconnaissance")]
        public DateTime? DateReconnaissance { get; set; }

        //Date à laquelle le professionnel a déclaré renoncer à l’exercice d’un savoir-faire ou date à laquelle il ne souhaite plus le faire apparaître.
        [DataType(DataType.Date)]
        [Display(Name = "Date Abandon")]
        public DateTime? DateAbandon { get; set; }
        //code type Savoir Faire

         public MetaDonnee MetaDonnee { get; set; }

        //RELATION DOSSIER PROFESSIONNEL D'APRES SCHEMA
        public string ExerciceProfessionnelId { get; set; }
        public ExerciceProfessionnel ExerciceProfessionnel { get; set; }
        //FIN RELATION

    }
}
