using MOS_Management.Models.ClassesCommunes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
Caractéristiques opérationnelles de l’exercice d’un professionnel au sein d’une organisation interne.
*/


namespace MOS_Management.Models.ProfessionnelDossier
{
    public class SituationOperationnelle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SituationOperationnelleId { get; set; }
        /*
        L’indicateur Carte Vitale acceptée précise si le professionnel, dans le cadre de cette situation opérationnelle, dispose
        des moyens techniques pour prendre en charge la carte vitale ou pas.
        0 : pas de prise en charge de la carte vitale.
        1 : prise en charge de la carte vitale.
        */
        [Display(Name ="Prise en charge carte vitale")]
        public bool? CarteVitale { get; set; }
        /*
        L'option pratique tarifaire maîtrisée (OPTAM) a remplacé le contrat d'accès aux soins (CAS) en 2017.
        L’option pratique tarifaire maîtrisée (OPTAM) est un dispositif proposé par l’Assurance Maladie aux médecins
        conventionnés, ayant pour objectif principal de faciliter l’accès aux soins en limitant, sans les supprimer, les
        dépassements d’honoraires.
        Les médecins exerçant une spécialité chirurgicale ou de chirurgie obstétrique, qui ont réalisé au moins 50 actes de
        chirurgie ou d'obstétrique ont la possibilité d'adhérer à l'option pratique tarifaire maîtrisée chirurgie et obstétrique
        (OPTAM-CO).
        Synonyme : optionPratiqueTarifaireMaîtrisée
        */
        [Display(Name = "Pratique tarifaire")]
        public bool? PratiqueTarifaireMaîtrisée { get; set; }
        /*
        Secteur de conventionnement du professionnel libéral auquel il a adhéré auprès de l'Assurance Maladie.
        Nomenclature(s) associée(s) :
        TRE_R282-CNAMAmeliSecteurConventionnement
        */
        [MaxLength(3)]
        [Display(Name = "Conventionnement")]
        public string SecteurConventionnementId { get; set; }
        /*
        L’indicateur visite à domicile précise si le professionnel, dans le cadre de cette situation opérationnelle, propose des
        visites à domicile ou pas.
        0 : pas de visite à domicile proposée.
        1 : visite à domicile proposée.
        */
        [Display(Name = "Visite à domicile")]
        public bool? VisiteDomicile { get; set; }

        public Horaire Horaire { get; set; }
        public IEnumerable<TeleCommunication> TeleCommunications { get; set; }


       
    }
}
