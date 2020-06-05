﻿


using MOS_Management.Models.ClassesCommunes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
La classe OrganisationInterne (OI) est une classe abstraite qui contient les attributs inhérents et
communs aux classes décrivant des structures organisationnelles (ou organisations internes),
portant des activités sur un lieu au sein d'une entité géographique.
Une organisation interne (OI) peut être composée d’autres organisations internes. Par exemple,
un pôle peut être composé de structures internes (ou services), une structure interne peut être
composée d'unités fonctionnelles, une unité fonctionnelle peut être composée d'unités
élémentaires.
Synonymes RASS: Entité fonctionnelle/ Entité organisationnelle
Mise en correspondance FHIR R4: Organization + Location + HealthcareService
avec Organization.partOf désignant l'entité juridique ou l'entité géographique ou l'organisation
interne dont dépend l'organisation interne
*/

namespace MOS_Management.Models.OrganisationDossier
{
    public class OrganisationInterne
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string OrganisationInterneId { get; set; }

        /*
        Champ créée pour gérer la relation cyclique 
        */
        //TODO Faire liste de tout les oi de la meme entite geographique ++++
        [Display(Name = "Superviseur")]
        public int OrganisationInterneSupervisanteId { get; set; }

        /*
        Identifiant de l'organisation interne, unique et persistant au niveau national.
        Mise en correspondance FHIR R4: Organization.identifier
        */
        [MaxLength(20)]
        [Display(Name ="Identifiant")]
        public string  Identifiant { get; set; }

        /*
        Type d'organisation interne (pôle, structure interne ou service, unité
        fonctionnelle, unité élémentaire, etc.).
        Mise en correspondance FHIR R4: Organization.type
        Nomenclature(s) associée(s) :
        TRE_R207-TypeOrganisationInterne
        */
        [MaxLength(2)]
        [Display(Name = "Type Organisation Interne")]
        public string TypeOrganisationInterneId { get; set; }

        /*
        Champ(s) de l’activité des établissements de santé publics et privés
        français, notamment :
        - médecine, chirurgie, obstétrique (MCO),
        - soins de suite et de réadaptation (SSR),
        - psychiatrie (PSY).
        Ces champs d'activité seront enrichis avec l'intégration des établissements
        du secteur médico-social.
        Nomenclature(s) associée(s) :
        TRE_R227-ChampActivite
        */
       // public IEnumerable<ChampActiviteOI> ChampActiviteOIs { get; set; }

        /*
        Un mode de prise en charge se définit par une organisation quant à la
        durée de prise en charge et le niveau de soins.
        Nomenclature(s) associée(s) :
        TRE_R213-ModePriseEnCharge
        */
      //  public IEnumerable<ModePriseEnChargeOI> ModePriseEnChargeOIs { get; set; }

        /*
        La catégorie d'organisation caractérise la nature particulière d’une
        organisation liée à un agrément, un personnel spécialement formé, un
        environnement particulièrement adapté à l'état de santé des patients, etc.
        Nomenclature(s) associée(s) :
        TRE_R244-CategorieOrganisation
        */
        [MaxLength(2)]
        [Display(Name = "Categorie Organisation")]
        public string CategorieOrganisationId { get; set; }

        /*
        Un acte spécifique est une action menée par un ou plusieurs acteur(s) de
        santé dans le cadre d’une activité. Cet acte peut correspondre à une
        technique spécialisée ou traduire une expertise discriminante dans le
        parcours de santé.
        Les actes habituels réalisés dans le cadre des activités proposées par
        l’unité ne sont pas des actes spécifiques.
        Les actes spécifiques décrits sont réalisés avec les ressources propres de
        l’unité ou via des ressources mises à disposition dans le cadre d’une
        convention à la condition que ces ressources interviennent au sein de
        l'unité (sur site).
        Mise en correspondance FHIR R4: HealthcareService.type
        Nomenclature(s) associée(s) :
        TRE_R210-ActeSpecifique
        */
    //    public IEnumerable<ActeSpecifiqueOI> ActeSpecifiqueOIs { get; set; }

        /*
        L’ouverture annuelle indique le nombre de jours dans l’année au cours
        desquels l’OI est en mesure d’accueillir une personne en situation de
        handicap ou une personne âgée en perte d'autonomie.
        Nomenclature(s) associée(s) :
        TRE_R238-OuvertureAnnuelle
        */
        [MaxLength(2)]
        [Display(Name = "Acceuil P.S.H ou P.P.A")]
        public string OuvertureAnnuelleId { get; set; }

        /*
        La temporalité d’accueil précise si l’unité offre un accueil permanent ou
        temporaire, sachant que temporaire est limité à 90 jours maximum par an
        dans un établissement.
        Nomenclature(s) associée(s) :
        TRE_R240-TemporaliteAccueil
        */
        [MaxLength(2)]
        [Display(Name = "Acceuil")]
        public string TemporaliteAccueilId { get; set; }

        /*
        Une spécialisation de prise en charge est une grande catégorie de
        troubles, de pathologies ou de déficiences pour lesquelles l'organisation
        interne dispose d’une expertise, de compétences et/ou d’équipements
        spécifiques pouvant être discriminants dans le choix d’orientation du
        patient.
        Nomenclature(s) associée(s) :
        TRE_R245-SpecialisationDePriseEnCharge
        */
      //  public IEnumerable<SpecialisationDePriseEnChargeOI> SpecialisationDePriseEnChargeOIs { get; set; }

        /*
        Indique si l’unité accepte d’accueillir des personnes en situation de
        handicap de façon séquentielle, c'est à dire sur une partie de la semaine.
        0 = L'unité n'accepte pas l'accueil séquentiel
        1 = L'unité accepte l'accueil séquentiel
        */
        public bool AccueilSequentielAccepte { get; set; }

        /*
        Le secteur psychiatrique (secteur de psychiatrie, ou sectorisation)
        correspond à une aire géographique à laquelle sont rattachées des
        structures de relais et de soins qui prennent en charge des patients
        résidants sur ce secteur. Cet attribut est le libellé du secteur de
        psychiatrie. Le secteur de psychiatrie s'exprime sous la forme d'un libellé.
        */
  //      public IEnumerable<Sectorisation> Sectorisations { get; set; }

        /*
        Type d'autorisation d'obstétrique pour l'OI, conforme à l'autorisation
        donnée à l'EG.
        Cette autorisation traduit le niveau de prise en charge possible en fonction
        des risques que présente la grossesse de la patiente.
        Nomenclature(s) associée(s) :
        TRE_R253-TypeMaternite
        */
        [MaxLength(4)]
        [Display(Name = "Niveau maternité")]
        public string NiveauMaterniteId { get; set; }

        /*
        Date d'ouverture de l'organisation interne
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date ouverture")]
        public DateTime? DateOuverture { get; set; }

        /*
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date fermeture")]
        public DateTime? DateFermeture { get; set; }

        /*
        */
        [MaxLength(3)]
        [Display(Name = "Motif fermeture")]
        public string TypeFermetureId { get; set; }

       

        //IEnumerable<Patientele> Patienteles { get; set; }
        //IEnumerable<Zone> Zones { get; set; }

        /*
        La capacité d'accueil fournit le nombre de lits et/ou places disponibles ou   installés.
        */
        public CapaciteAcceuilCrise CapaciteAcceuilCrise { get; set; }

        /*
        La capacité d'accueil en situation de crise représente le nombre de places
        supplémentaires, par rapport à la capacité théorique usuelle, que
        Table 29 Attributs de la classe "OrganisationInterne"
        l’établissement peut mettre à disposition pour accueillir des patients lors
        du déclenchement du plan ORSAN, en fonction du délai.
        */
        public CapaciteAcceuil CapaciteAcceuil { get; set; }

        public IEnumerable<Horaire> Horaires { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        public IEnumerable<TeleCommunication> TeleCommunications { get; set; }
       // public IEnumerable<SituationOperationnelle> SituationOperationnelles { get; set; }
       // public IEnumerable<EquipementOperationnelle> EquipementOperationnelles { get; set; }
      //  public IEnumerable<ActiviteOperationnelle> ActiviteOperationnelles { get; set; }

        public IEnumerable<Adresse> Adresses { get; set; }
        public IEnumerable<BoileLettreMMS> BoileLettreMMs { get; set; }
        public IEnumerable<CapaciteHabitation> CapaciteHabitations { get; set; }

        //TJ
       // public IEnumerable<EntiteGeoOrganisation> EntiteGeoOrganisations { get; set; }
        //TJ
       // public IEnumerable<OrganisationActivite> OrganisationActivites { get; set; }

    }
}
