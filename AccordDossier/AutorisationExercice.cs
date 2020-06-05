
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
L'accès aux professions de santé est soumis à des conditions concernant les diplômes obtenus :
généralement est requis un diplôme français (DE de médecine, etc. ou européen (dans les
professions pour lesquelles il existe des accords de reconnaissance mutuelle des diplômes).
Pour les personnes ne remplissant pas ces conditions (diplômes hors UE, par exemple), les
diplômes obtenus doivent être complétés d'une autorisation afin de permettre l'entrée dans la
profession.
Il peut s'agir:
** d'une autorisation délivrée par le Ministère de la Santé,
** d'une autorisation délivrée par l'Ordre au vu de la jurisprudence (Hochsmann, etc.).
*/

namespace MOS_Management.Models.AccordDossier
{
    public class AutorisationExercice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AutorisationExerciceId { get; set; }
        /*
        Type d’autorisation (ex. Autorisation ministérielle de plein exercice, etc.).
        Nomenclature(s) associée(s) :
        TRE_R17-TypeAutorisation
        */
        [MaxLength(5)]
        [Display(Name = "Type Autorisation")]
        public TypeAutorisation TypeAutorisation { get; set; }
        /*
        Discipline à laquelle l'autorisation d'exercice est restreinte, le cas échéant.
        Nomenclature(s) associée(s) :
        TRE_R18-DisciplineAutorisation
        */
        [MaxLength(6)]
        [Display(Name = "Discipline")]
        public DisciplineAutorisation DisciplineAutorisation { get; set; }
        /*
        Date à partir de laquelle l’autorisation s’applique.
        */
        [Display(Name = "Début autorisation")]
        [DataType(DataType.Date)]
        public DateTime? DebutAutorisation { get; set; }
        /*
        */
        [DataType(DataType.Date)]
        [Display(Name = "Fin autorisation")]
        public DateTime? FinAutorisation { get; set; }
        /*
        Profession pour laquelle l'autorisation est délivrée.
        Nomenclature(s) associée(s) :
        TRE_G15-ProfessionSante
        */
        [MaxLength(3)]
        [Display(Name = "Profession Sante")]
        public Profession Profession  { get; set; }

        public MetaDonnee MetaDonnee { get; set;  }

    }
}
