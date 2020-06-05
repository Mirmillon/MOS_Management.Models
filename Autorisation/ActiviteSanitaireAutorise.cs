
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
using MOS_Management.Models.StructureDossier;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.Autorisation
{
    public class ActiviteSanitaireAutorisee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ActiviteSanitaireAutoriseeId { get; set; }
        /*
        Identifiant fonctionnel de l'autorisation ARHGOS de l’implantation de l'activité sanitaire. 
        */
        [MaxLength(20)]
        [Display(Name = "Identifiant ARHGOS")]
        public  AutorisationImplantationArhgos AutorisationImplantationArhgos { get; set; }
        /*
        Date de délivrance de l'autorisation de l'activité sanitaire donnée à l'entité juridique.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Autorisation")]
        public DateTime? DateAutorisation { get; set; }
        /*
        Code définissant:
        ** une activité de soins autorisée (article L.6122-1 du CSP), la liste  des activités de soins soumises à autorisation est fixée par décret
        en Conseil d'Etat (article L.6122-25 du CSP) ;
        ** une activité soumise à autorisation autre que les activités de soins dans le CSP;
        ** une activité soumise à reconnaissance contractuelle dans les contrats pluriannuels d'objectifs et de moyens (CPOM).
        Mise en correspondance FHIR R4: HealthcareService.specialty
        Nomenclature(s) associée(s) :
        TRE_R274-ActiviteSanitaireRegulee
        ASS_A16-TypeActiviteModaliteForme
        */
        [MaxLength(3)]
        [Display(Name = "Activité régulée")]
        public ActiviteAutorisee ActiviteAutorisee  { get; set; }
        /*
        Code typant les activités autorisées en:
        ** activité de soins soumise à autorisation dans le CSP;
        ** activité de soins soumise à autorisation autre que les activités
        de soins dans le CSP;
        ** activité de soins soumise à reconnaissance contractuelle dans
        les contrats pluriannuels d'objectifs et de moyens (CPOM).
        Nomenclature(s) associée(s) :
        TRE_R277-CategorieActiviteSanitaireRegulee
        */
        [MaxLength(2)]
        [Display(Name = "Catégorie Activité régulée")]
        public TypeActiviteAutorisee TypeActiviteAutorisee { get; set; }
        /*
        Les modalités sont des modes d’application ou des types de soins prévus par les textes réglementaires encadrant chaque activité de
        soins. Ce sont des pratiques thérapeutiques. 
        Une activité de soins peut ou non avoir des modalités (dans ce cas, le code de la modalité est "00"). 
        Les modalités peuvent être communes à plusieurs activités de soins ou spécifiques à une seule.
        Nomenclature(s) associée(s) :
        TRE_R275-ModaliteActivite
        */
        [MaxLength(3)]
        [Display(Name = "Activité")]
        public Modalite Modalite { get; set; }
        /*
        Une forme est un type d’organisation de prise en charge
        (exemples: hospitalisation à temps complet, hospitalisation à
        domicile, chirurgie ambulatoire, etc.).
        Nomenclature(s) associée(s) :
        TRE_R276-FormeActivite
        */
        [MaxLength(2)]
        [Display(Name = "Forme Activité")]
        public Forme Forme { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //RELATION DOSSIER
        public List<ImplementationActiviteSanitaireAutorisee> ImplementationActiviteSanitaireAutorisees { get; set; }
        //FIN

        //RELATION AUTRE DOSSIER
        public string EntiteJuridiqueId { get; set; }
        public EntiteJuridique EntiteJuridique { get; set; }



    }
}
