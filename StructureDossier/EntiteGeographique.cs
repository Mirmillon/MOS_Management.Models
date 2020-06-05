


using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
L'Entité Géographique (EG) correspond à la notion d'établissement : 
** Pour les établissements inscrits au FINESS, cette notion d'établissement résulte du croisement de trois critères : 
- Un critère géographique : Est un établissement tout lieu dont l'implantation d’activité(s) ou d’équipement(s) est géographiquement distincte d'une autre implantation. 
Ainsi un Centre Hospitalier Régional comprend autant d'établissements que d'implantations géographiques différentes. 
Un établissement principal et son établissement secondaire situé à 1 km constituent deux établissements distincts dans FINESS. 
L'implantation géographique peut-être décrite soit avec l'attribut addresseEG soit au travers de la classe Lieu.
- Un critère budgétaire : Pour une même implantation géographique, on distingue autant d'établissements du secteur public qu'il y a de budgets distincts (budget général, budget annexe).
Ainsi un ESAT et son foyer d'hébergement constituent deux établissements même s'ils sont implantés à la même adresse.
- Un critère d’activité : Pour une même implantation géographique et un même budget, on distingue autant d'établissements que de « catégorie d’établissement » décrivant l’activité principale autorisée.
Ainsi un centre hospitalier et son EHPAD, financés par le même budget, constituent deux établissements même s'ils sont implantés à la même adresse.
** Pour les entreprises inscrites dans le SIRENE, l'EG correspond à un établissement de la personne morale, elle est identifiée par un numéro SIRET.

Synonymes: Etablissement, structure
Mise en correspondance FHIR R4: Organization
avec Organization.partOf désignant l'entité juridique dont l'entité géographique dépend.
Mise en correspondance SEMIC : Legal Entity
*/

namespace MOS_Management.Models.StructureDossier
{
    public class EntiteGeographique
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string  EntiteGeographiqueId { get; set; }

        /*
        Numéro FINESS de l'entité géographique.
        Le numéro FINESS étant porteur intrinsèquement de liens avec le domaine sanitaire ou le domaine médico-social, il est, s'il existe, à privilégier pour l’identification des entités géographiques en tant qu’acteurs sanitaires et médico-sociaux par rapport au numéro SIRET (Référentiel d’identification des acteurs sanitaires et médico-sociaux - Politique Générale de Sécurité des Systèmes d’Information de Santé (PGSSI-S)).
        A chaque EG (établissement) est attribué un numéro FINESS qui est composé de 9 caractères numériques, tels que :
        ** Position 1-2 : numéro du département d'implantation ("2A", "2B" pour la Corse; "97" pour les départements d’Outre-mer; "98" pour Mayotte);
        ** Position 3 : "0";
        ** Position 4-8: "1" pour Guadeloupe, "2" pour Martinique, "3" pour Guyane, "4" pour Réunion, "5" pour Saint-Pierre-et-Miquelon + numéro d'ordre de 4 chiffres;
        ** Position 4-8 : numéro d’ordre de 5 chiffres pour tous les autres départements;
        ** Position 9 : clé de Luhn calculée automatiquement.
        Mise en correspondance FHIR R4: Organization.identifier
        */
        [Display(Name = "Numéro FINESS")]
        [MaxLength(9)]
        public FINESS Finess { get; set; }

        /*
        Le numéro SIRET est le numéro unique d'identification, attribué par l'INSEE, à chaque entité géographique.
        Ce numéro est un simple numéro d'ordre, composé de 14 chiffres non significatifs:
         ** les 9 chiffres du numéro SIREN de l'entreprise dont l'établissement dépend, suivis des 5 chiffres du numéro interne de classement (NIC), lui-même constitué de 4 chiffres complétés d'une clé de Luhn.
        Le numéro SIRET n'a aucun lien avec les caractéristiques de l'établissement. Il est fermé quand l'activité cesse dans l'établissement concerné ou lorsque l'établissement change d'adresse.
        Mise en correspondance FHIR R4: Organization.identifier
        */
        [Display(Name = "Numéro SIRET")]
        [MaxLength(14)]
        public SIRET Siret { get; set; }

        /*
        Identifiant spécifique généré par le RPPS ou ADELI lors de la création d'une structure d'exercice pour un cabinet individuel et un cabinet de groupe. Il est communément connu sous le nom de RPPS-rang ou ADELI-rang :
        - le RPPS-rang, de 14 caractères, est formé des 11 caractères de l’identifiant RPPS du titulaire du cabinet, suivi d’un numéro d’ordre sur 2 caractères et d’une clé de Luhn (1 caractère) ;
        - l’ADELI-rang, de 11 caractères, est formé des 9 caractères du numéro ADELI du titulaire du cabinet suivi d’un numéro d’ordre sur 2 caractères.
        Cet identifiant est utilisé dans les échanges techniques entre le RPPS ou ADELI avec le FNPS de la CNAM, se substituant ainsi au numéro de SIRET dans le cas où ce dernier n'est pas encore connu du RPPS ou d’ADELI.
        Synonyme : numEG_RPPS_ADELI 
        Mise en correspondance FHIR R4: Organization.identifier
        */
        [Display(Name = "Numéro Etablissement")]
        [MaxLength(14)]
        public IdentifiantEntiteGeographique IdentifiantEntiteGeographique { get; set; }
       
        /*
        Identification nationale de l'Entité géographique initiée pour les besoins du SI-CPS.
        Cette identification est obtenue par la concaténation du type d'identifiant national de structure (provenant de la nomenclature TRE_G07-TypeIdentifiantStructure) et de l'identifiant de la structure:
        ** 0 + Identifiant cabinet ADELI (identifiantEG);
        ** 1 + N° FINESS (entité juridique et entité géographique indéterminées);
        ** 3 + N° SIRET;
        ** 4 + Identifiant cabinet RPPS (identifiantEG).
        Synonyme : Struct_IdNat (CI-SIS)
        Mise en correspondance FHIR R4: Organization.identifier
        */
        [Display(Name = "Identifiant National")]
        [MaxLength(16)]
        public IdentifiantNationalEntiteGeographique IdentifiantNationalEntiteGeographique { get ; set; }

        /*
        Type d’identifiant national de la structure.
        Nomenclature(s) associée(s) :
        TRE_G07-TypeIdentifiantStructure
        */
        [MaxLength(2)]
        [Display(Name = "Identifiant Type Structure")]
        public IdentifiantNationalStructure IdentifiantNationalStructure { get; set; }

        /*
        Le "numéro éducation nationale de l'établissement" est un numéro associé délivré par l’Éducation nationale, pour tous les établissements et services pour enfants et adolescents handicapés 
        qui emploient du personnel de l’Education nationale.
        */
        [MaxLength(10)]
        [Display(Name = "Identifiant Education Nationale")]
        public string NumeroEducationNationale { get; set; }

        /*
        Nom sous lequel l'entité géographique exerce son activité. 
        Il s’agit, par exemple, de l’enseigne commerciale pour les pharmacies . 
        Dans le cas d'un établissement enregistré dans le FINESS, cet attribut correspond à la notion de "raison sociale d'un établissement" renseignée dans le FINESS. 
        Mise en correspondance FHIR R4: Organization.name
        */
        [MaxLength(100)]
        [Display(Name = "Dénomination")]
        public string NomHabituel { get; set; }

        /*
        Nom, sous sa forme la plus longue et complète, sous lequel l'entité géographique exerce son activité (acronymes, sigles ou abréviations développés).
        Mise en correspondance FHIR R4: Organization.alias
        */
        [MaxLength(200)]
        [Display(Name = "Dénomination longue")]
        public string Denomination { get; set; }

        /*
        Suite de la dénomination de l'entité géographique, si elle existe. Ce complément peut contenir notamment des informations facilitant l'adressage d'un courrier aux structures.
        */
        [MaxLength(100)]
        [Display(Name = "Compléement Dénomination")]
        public string ComplementDenomination { get; set; }

        /*
        Champ(s) de l’activité des établissements de santé publics et privés français, notamment : 
        - médecine, chirurgie, obstétrique (MCO),
        - soins de suite et de réadaptation (SSR), 
        - psychiatrie (PSY).
        Ces champs d'activité seront enrichis avec l'intégration des établissements du secteur médico-social.
        Nomenclature(s) associée(s) :
        TRE_R227-ChampActivite
        */
        [Display(Name = "Champ Activité")]
        public ChampActivite ChampActivite { get; set; }

        /*
        Le type d’établissement détermine si c'est un établissement principal ou secondaire.
        */
        [Display(Name = "Etablissement secondaire")]
        public bool EtablissementSecondaire { get; set; }

        /*
        Dans le cas d’un établissement secondaire : Numéro FINESS de l’établissement principal dont dépend l’établissement.
        Mise en correspondance FHIR R4: Organization.identifier*/
        //TODO Affichage conditionnel
        [MaxLength(9)]
        [Display(Name = "Numéro FINESS Etablissement principal")]
        public FINESS2 FINESS2 { get; set; }

        /*
        Un secteur d'activité regroupe les établissements partageant la même activité de santé. 
        Exemples (établissement public de santé, maison de santé, etc.)
        Nomenclature(s) associée(s) :
        TRE_R02-SecteurActivite
        */
        [Display(Name = "Secteur Activité")]
        [MaxLength(4)]
        public SecteurActivite SecteurActivite { get; set; }

        /*
        La catégorie d'établissement est le cadre réglementaire dans lequel s'exerce l'activité de l'entité géographique. 
        Les catégories d'établissement sont elles-mêmes classifiées en grands agrégats qui sont :
        ** Etablissements relevant de la loi hospitalière,
        ** Autres établissements de soins et de prévention,
        ** Autres établissements à caractère sanitaire,
        ** Etablissements et services sociaux d'accueil, hébergement, assistance, réadaptation,
        ** Etablissements et services sociaux d'aide à la famille,
        ** Etablissements de formation des personnels sanitaires et sociaux.
        Nomenclature(s) associée(s) :
        TRE_R66-CategorieEtablissement
        ASS_X10-AgregatCategorieEtablissement
        */
        [Display(Name = "Catégorie d'établissement")]
        [MaxLength(3)]
        public CategorieEtablissement CategorieEtablissement { get; set; }

        /*
        Agrégat de catégories d'établissements de niveau 1. L'agrégat de niveau 1 représente des regroupements d'agrégat de niveau 2. Par exemple, le code 1000 "Etablissement relevant de la loi hospitalière" regroupe les codes d'agrégat de niveau 2 1100 et 1200.
        Nomenclature(s) associée(s) :
        ASS_X10-AgregatCategorieEtablissement
        TRE_R63-AgregatCategorieEtablissementNiv1
        */
        [MaxLength(4)]
        [Display(Name = "Categorie Etablissement Niv 1")]
        public CategorieEtablissementN1 CategorieEtablissementN1 { get; set; }

        /*
        Agrégat de catégories d'établissements de niveau 2. L'agrégat de niveau 2 représente des regroupements d'agrégats de niveau 3. Par exemple, le code 1100 "Etablissement hospitaliers" regroupe les codes d'agrégat de niveau 3 1101, 1102, etc.
        Nomenclature(s) associée(s) :
        ASS_X10-AgregatCategorieEtablissement
        TRE_R64-AgregatCategorieEtablissementNiv2
        */
        [MaxLength(4)]
        [Display(Name = "Categorie Etablissement Niv 2")]
        public CategorieEtablissementN2 CategorieEtablissementN2 { get; set; }

        /*
         Agrégat de catégories d'établissements de niveau 3. L'agrégat de niveau 3 représente des regroupements de catégories d'établissement. Par exemple, le code 1101 "Centres hospitaliers régionaux" regroupe les catégories d'établissement 101, 106 etc.
        Nomenclature(s) associée(s) :
        ASS_X10-AgregatCategorieEtablissement
        TRE_R65-AgregatCategorieEtablissement
        */
        [MaxLength(4)]
        [Display(Name = "Categorie Etablissement Niv 3")]
        public CategorieEtablissementN3 CategorieEtablissementN3 { get; set; }

        /*
        Toute entité juridique et chacun de ses établissements (EG) se voit attribuer par l'Insee, lors de son inscription au répertoire SIRENE, un code caractérisant son activité principale par référence à la nomenclature d'activités française (NAF rév. 2).
        Plus précisément, on distingue le code APET pour les EG.
        Nomenclature(s) associée(s) :
        TRE_R75-InseeNAFrev2Niveau5
        */
        [MaxLength(7)]
        [Display(Name = "Code APET")]
        public APET APET  { get; set; }

        /*
        Le mode de tarification détermine l'autorité responsable de la fixation du tarif principal de l'établissement et la procédure utilisée. Il est unique pour un établissement FINESS donné.
        Nomenclature(s) associée(s) :
        TRE_R74-ModeFixationTarifaire
        */
        [MaxLength(2)]
        [Display(Name = "Fixation Tarif")]
        public ModeFixationTarif ModeFixationTarif { get; set; }

        /*
        Modalités de participation au service public hospitalier.
        Nomenclature(s) associée(s) :
        TRE_R73-ESPIC
        */
        //TODO conditionnel
        [MaxLength(2)]
        [Display(Name = "Modalite Participation SPH")]
        public ModaliteParticipationSPH ModaliteParticipationSPH { get; set; }

        /*
        Nature du budget alloué à l'établissement dont les valeurs sont "G" pour général et "A" pour annexe.
        */
        [MaxLength(15)]
        [Display(Name = "Nature  budget")]
        public string NatureBudgetEtablissement { get; set; }

        /*
        Habilitation ou conventionnement de l'entité géographique permettant aux personnes accueillies de bénéficier des aides financières, si elles remplissent les conditions.
        Nomenclature(s) associée(s) :
        TRE_R241-TypeAideFinanciere
        */
        [MaxLength(2)]
        [Display(Name = "Aide financière")]
        public AideFinanciere AideFinanciere { get; set; }

        /*
        L'habilitation aux soins sans consentement traduit que l'établissement est autorisé à prendre en charge des patients sans leur consentement. Cette autorisation est donnée par le directeur général de l’ARS après avis du préfet.
        Valeurs possibles :
         0 = L'établissement ne possède pas d'autorisation aux soins sans consentement
         1 = L'établissement possède une autorisation aux soins sans consentement
        */
        [Display(Name = "Soins Sans Consentement")]
        public bool? HabilitationSoinSansConsentement { get; set; }

        /*
        L’indicateur hébergement des familles précise si l'établissement peut héberger les familles des personnes prises en charge. 
        Valeurs possibles :
        0 = L'établissement ne peut pas héberger les familles des personnes prises en charge
        1 = L'établissement peut héberger les familles des personnes prises en charge
        */
        [Display(Name = "Hebergement Famille")]
        public bool? HebergementFamille { get; set; }

        /*
        Attribut créé par moi
        */
        [Display(Name = "Changement numèro SIRET")]
        public bool? ChangementNumeroSiret { get; set; }

        /*
        Date de modification du numéro SIRET.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Changement Siret")]
        public DateTime? DateChangementSiret { get; set; }

        /*
        Origine/nature de modification du SIRET(motif de modification de l’identifiant).
        */
        [Display(Name = "Motif modification  Siret")]
        [MaxLength(200)]
        public string OrigineModificationSIRET { get; set; }

        /*
        Indicateur de l’activité de l'entité géographique, si celle-ci est active (ou ouverte) ou inactive (ou fermée).
        Mise en correspondance FHIR R4: Organization.active
        */
        [Display(Name = "Etablissement actif")]
        public bool? Actif { get; set; }

        /*
        Date d’ouverture réelle de fonctionnement de l’établissement.
        Pour les établissements soumis à autorisation, elle est constatée par la première visite de conformité du premier équipement autorisé. 
        La date d’ouverture doit être supérieure ou égale à la date d’autorisation.
        */
        [Display(Name = "Date ouverture")]
        [DataType(DataType.Date)]
        public DateTime? DateOuverture { get; set; }

        /*
        Date d’autorisation qui correspond à la date de l’arrêté autorisant la création d’un établissement ou de la première autorisation délivrée pour des équipements.
        */
        //TODO A verifier
        [DataType(DataType.Date)]
        [Display(Name = "Date autorisation")]
        public DateTime? DateAutorisation { get; set; }

        /*
        La date de caducité indique la limite autorisant la réalisation de l’opération pour laquelle il y a autorisation. Elle est calculée automatiquement lorsque la date d’autorisation est renseignée. Elle disparait lorsque la date d’ouverture est renseignée.
        Par défaut, la date de caducité calculée automatiquement dans FINESS est de trois ans. En cas de début de travaux, une quatrième année est autorisée par les textes.
        */
        //TODO Conditionnel
        [DataType(DataType.Date)]
        [Display(Name = "Date Certificat caducité")]
        public DateTime? DateCaducite { get; set; }

        /*
        Indicateur de caducité de l'établissement:
        - « N » par défaut, lorsque l’établissement est autorisé non ouvert (la date d’ouverture n’est pas renseignée);
        - « O » à indiquer lorsqu’un constat de caducité a été relevé sur l'établissement
        */
        [Display(Name = "Certificat caducité")]
        public bool? ConstatCaducite { get; set; }

       

        /*
        Date de fermeture de l'entité géographique. La date doit être supérieure à la date d’ouverture.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date fermeture")]
        public DateTime? DateFermeture { get; set; }

        /*
        Type de fermeture de l'entité géographique, au sens des règles de gestion du SI FINESS (par exemple: fermeture définitive, fermeture provisoire), obligatoire lors de la fermeture de l'entité.
        Nomenclature(s) associée(s) :
        TRE_R286-TypeFermeture
        */
        [MaxLength(3)]
        [Display(Name = "Motif fermeture")]
        public TypeFermeture TypeFermeture{ get; set; }

        /*
        Information précisant dans quelle mesure le lieu est conforme aux dispositions règlementaires relatives à l’accessibilité des établissements recevant du public (ex : accessible, non accessible, sur demande, non communiqué, etc.).
        Rappel sur l'obligation d'accessibilité des établissements recevant du public (ERP) aux personnes handicapées (service-public.fr):
        Les établissements ouverts au public (magasin, bureau, hôtel, etc.) doivent être accessibles aux personnes handicapées. Les établissements recevant du public (ERP) non conformes aux règles d'accessibilité sont tenus de s'inscrire à un Agenda d'Accessibilité Programmée (Ad'AP) qui permet d'engager les travaux nécessaires dans un délai limité.
        Règles d'accessibilité:
        Les normes d'accessibilité doivent permettre aux personnes handicapées de circuler avec la plus grande autonomie possible, d'accéder aux locaux et équipements, d'utiliser les équipements et les prestations, de se repérer et de communiquer.
        L'accès concerne tout type de handicap (moteur, visuel, auditif, mental...).
        Les conditions d'accès doivent être les mêmes que pour les personnes valides ou, à défaut, présenter une qualité d'usage équivalente.
        L'accessibilité de ces établissements et de leurs abords concerne :
        ** les cheminements extérieurs,
        ** le stationnement des véhicules,
        ** les conditions d'accès et d'accueil dans les bâtiments,
        ** les circulations horizontales et verticales à l'intérieur des bâtiments,
        ** les locaux intérieurs et les sanitaires ouverts au public,
        ** les portes, les sas intérieurs et les sorties,
        ** les revêtements des sols et des parois,
        ** les équipements et mobiliers intérieurs et extérieurs susceptibles d'y être installés (dispositifs d'éclairage et d'information des usagers, par exemple).
        Nomenclature(s) associée(s) :
        TRE_R202-AccessibiliteLieu

        */
        [MaxLength(2)]
        [Display(Name = " Accessibilite Lieu")]
        public AccessibiliteLieu AccessibiliteLieu { get; set; }

        /*
        Indicateur portant sur l'existence d'une zone de poser pour hélicoptère sur le site même.
        Valeurs possibles:
         0 = Pas de zone de poser
         1 = Existence d'une zone de poser
        */
        [Display(Name ="Zone Hélicoptére")]
        public bool? ZoneAPoser { get; set; }

        /*
        */
        public CapaciteAcceuil CapaciteAcceuil { get; set; }

        public List<CapaciteHabitation> CapaciteHabitations { get; set; }
        /*
        Il s'agit du nombre de places temporaires dédiées à l'aide sociale dans l'établissement
        */
        [Display(Name = "Nb de place temporaire Aide Sociale")]
        public Numerique NbPlaceAideSocialeTemporaire { get; set; }

        /*
        */
        [Display(Name = "Nb de place d'Aide Sociale")]
        public Numerique NbPlaceAideSocialePermanent { get; set; }

        public List<RessourceMaterielle> RessourceMaterielles { get; set; }

        public List<Tarif> Tarifs { get; set; }

        /*
        Le niveau de recours ORSAN correspond à une hiérarchisation fonctionnelle de la mobilisation des
        établissements pour accueillir les patients après régulation par le SAMU.
        Nomenclature(s) associée(s) :
        TRE_R284-NiveauRecoursORSAN
        */
        [MaxLength(2)]
        [Display(Name = "Recours ORSAN")]
        public NiveauRecoursORSAN NiveauRecoursORSAN { get; set; }

        public List<Adresse> Adresses { get; set;  }
        
        /*
        */
        public List<DivisionTerritorial> DivisionTerritoriales { get; set; }
        /*
        */
        public List<Contact> Contacts { get; set; }

        public List<TeleCommunication> TeleCommunications { get; set; }

        public List<BoileLettreMMS> boileLettreMMSs { get; set; }
        /*
        */
        public string VenteLigneURL { get; set; }
      
        /*CONSTRUCTEUR*/
        public EntiteGeographique()
        {
            EtablissementSecondaire = false;
            HabilitationSoinSansConsentement = false;
            HebergementFamille = false;
            ConstatCaducite = false;
            ZoneAPoser = false;
        }

        //
        
        public MetaDonnee MetaDonnee { get; set; }

        // RELATION STRUCTURE
        public string EntiteJuridiqueId { get; set; }
        public EntiteJuridique EntiteJuridique { get; set; }
        //FIN RELATION





    }
}
