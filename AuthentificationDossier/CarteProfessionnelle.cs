
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.ProfessionnelDossier;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
Données descriptives du moyen d’identification des personnes physiques via une carte de
professionnel. La carte est rattachée à l’exercice d’une profession donnée et non au professionnel
lui-même. Un professionnel exerçant simultanément deux professions a deux cartes.
*/

namespace MOS_Management.Models.AuthentificationDossier
{
    public class CarteProfessionnelle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CarteProfessionnelleId { get; set; }
        /*
        Type de carte de professionnel (CPx) :
        ** Carte de Professionnel de Santé (CPS)
        ** Carte de Professionnel de santé en Formation (CPF)
        ** Carte de Personnel d’Etablissement (CDE/CPE)
        ** Carte de Personnel Autorisé (CDA/CPA)
        Nomenclature(s) associée(s) :
        TRE_R87-TypeCarte
        */
        [MaxLength(3)]
        [Display(Name = "Type Carte")]
        public TypeCarte TypeCarte { get; set; }
        /*
        Numéro de la carte du professionnel.
        Codage des caractères en binaire codé en ASCII.
        */
        //TODO  Codage des caractères en binaire codé en ASCII.
        [Display(Name = "Numero Carte")]
        public string NumeroCarte { get; set; }
        /*
        Date et heure de début de validité de la carte. La date est en UTC (avec translation
        de l'heure locale en heure UTC par ajout du décalage négatif ou retranchement du
        décalage positif).
        */
        //TODO heure en UTC
        [Display(Name = "Date Debut Validite")]
        [DataType(DataType.Date)]
        public DateTime? DateDebutValidite { get; set; }
        /*
        Date et heure de fin de validité de la carte. La date est en UTC (avec translation de
        l'heure locale en heure UTC par ajout du décalage négatif ou retranchement du
        décalage positif).
        */
        [Display(Name = "Date Fin Validite")]
        [DataType(DataType.Date)]
        public DateTime? DateFinValidite { get; set; }
        /*
        Date de mise en opposition de la carte. Cette opposition implique la révocation des certifications embarquées dans la carte.
        */
        //TODO Révocation des certicats embarquées
        [Display(Name = "Date Opposition")]
        [DataType(DataType.Date)]
        public DateTime? DateOpposition { get; set; }


        public MetaDonnee MetaDonnee { get; set;  }

        //RELATION DANS DOSSIER
        public List<Certificat>  Certificats{ get; set; }
        //FIN RELATION

        //RELATION AUTRE DOSSIER
        public string ExerciceProfessionnelId { get; set; }
        public ExerciceProfessionnel ExerciceProfessionnel { get; set; }


    }
}
