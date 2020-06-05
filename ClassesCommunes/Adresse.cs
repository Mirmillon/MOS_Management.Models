using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromTexte;
using MOS_Management.Models.OrganisationDossier;
using MOS_Management.Models.PersonnePriseChargeDossier;
using MOS_Management.Models.ProfessionnelDossier;
using MOS_Management.Models.StructureDossier;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.ClassesCommunes
{
    public class Adresse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AdresseId { get; set; }
        //Pour distinguer personne morale ou physique
        [NotMapped]
        public string TypeDestinataire { get; set; }//Cree par moi n'existe pas dans MOS
        /*
        Eléments d'identification du destinataire c’est-à-dire la personne
        physique ou morale à qui un envoi est adressé.
        1) Le destinataire est une personne physique :
        * Qualité: civilité ou condition sociale, civile, juridique ou titre sous
        lequel une partie figure dans un acte juridique.
        * Prénom
        * Nom
        * Titre: désignation honorifique exprimant une distinction de rang, une
        dignité (titres nobiliaires, religieux, militaires, etc.).
        * Profession, fonction
        Une personne physique peut être désignée soit par son nom et
        éventuellement son prénom, soit par son nom et sa fonction ou sa
        profession, enfin, dans certains cas particuliers, par ses seuls titres,
        fonction ou profession.
        2) Le destinataire est une personne morale :
        * Forme juridique: Indication du statut juridique de la personne morale
        : SA, SARL, GIE, Société civile, Mutuelle, Association, Fondation, etc.
        * Raison ou dénomination sociale
        * Domaine d'activité
        * Enseigne commerciale
        * Nom commercial
        * Subdivision au sein de l'entreprise (Direction, service, etc.) ou
        organisation interne de la personne morale (fonctionnelle ou
        géographique).
        Une personne morale peut être désignée au moins par sa raison
        sociale, son enseigne ou nom commercial.
        */
        [Display(Name = "Destinataire")]
        public IdentificationDestinaire IdentificationDestinataire { get; set; }
        /*
        Eléments d'identification du domicilié c’est-à-dire le titulaire du domicile du destinataire(lieu ordinaire d'habitation, demeure légale et
        habituelle)
        1) Le domicilié est une personne physique:
        * Qualité
        * Prénom
        * Nom
        * Titre
        * Profession, fonction
        Les éléments d'identification du domicilié sont précédés de la mention
        «chez»
        2) Le domicilié est une personne morale:
        * Forme juridique
        * Dénomination sociale
        * Activité principale
        Enseigne ou nom de l'établissement
        * Subdivision au sein de l'entreprise (Direction, service,...).s
        */
        [Display(Name = "Domicile")]
        public IdentificationDomicile IdentificationDomicile { get; set; }
        /*
        Lieu où le destinataire prend possession de son courrier. 
        Il est matérialisé, dans la plupart des cas, par la présence d'une boîte aux lettres; il est constitué des éléments suivants :
        * Local ou logement : Numéro ou désignation d'appartement,
        logement, pièce, bureau, local commercial ou industriel
        * Accès au local ou au logement: indications de couloir, d'étage ou de
        niveau
        * Boîte aux lettres : Numéro voire dénomination (éventuellement
        CIDEX)
        * Accès à la boîte à lettres: si nécessaire,: identification du couloir
        d'accès, de la batterie de boîtes s'il en existe plusieurs
        * Code acheminement interne à l'entreprise (CAIE): Codification
        identifiant le découpage au sein de l'entreprise en vue du traitement de
        courrier par les services dédiés internes à l'entreprise. Les informations
        d'identification du domicilié (Chez M.X) pourraient figurer dans cet
        attribut.
        */
        [Display(Name = "Point Remise")]
        public PointRemise PointRemise { get; set; }
        /*
        Un complément de l'adresse au point géographique constitué des  éléments suivants:
        * Bâtiment: les bâtiments sont désignés par leur type (bâtiment,
        immeuble, tour,...), éventuellement des mentions d'orientation (est,
        ouest,...), une dénomination littérale ou une numérotation; exemple:
        Tour DELTA
        * Accès au bâtiment: l'accès au bâtiment est identifié par un numéro,
        une lettre, une combinaison alphanumérique. Ces éléments identifient
        une entrée, porte, etc.; exemple: Entrée A
        * Ensemble immobilier: ensemble d'habitations reliées à la voie
        publique par un ou plusieurs points d'accès (résidence, zone
        industrielle,...); exemple: Résidence des Fleurs.
        */
        
        [Display(Name = "Complement Adresse")]
        public ComplementGeographique ComplementGeographique { get; set; }
        /*
        Un numéro dans la voie; dans les cas de numérotation sans extension, il est composé de 0 à 4 caractères numériques au maximum.
        */
        [MaxLength(4)]
        [Display(Name = "Numéro")]
        public NumeroVoie NumeroVoie { get; set; }
        /*
        Extension ou indice de répétition: mention bis, ter, quater, ...ou une  lettre A, B, C, D, etc. lorsque ce caractère complète une numérotation de voirie.
        */
        [MaxLength(6)]
        [Display(Name = "Extension")]
        public Extension Extension { get; set; }
        /*
        Type de voie : rue, avenue, boulevard, etc.
        Attribut obsolète et non conforme à la norme postale en vigueur qui
        définit cette information comme faisant partie de l'attribut libelleVoie. Il
        apparait dans la classe Adresse uniquement parce que des systèmes
        existants l'utilisent encore.
        Nomenclature(s) associée(s) :
        TRE_R35-TypeVoie
        */
        [MaxLength(4)]
        [Display(Name = "Type de voie")]
        public TypeDeVoie TypeDeVoie { get; set; }
        /*
        Appellation qui est donnée à la voie par les municipalités. Ce libellé figure in extenso ou en abrégé sur les plaques aux différents angles de chaque rue.
        Synonyme: nom de la voie
        */
        [MaxLength(40)]
        [Display(Name = "Nom de la voie")]
        public NomDeVoie NomDeVoie { get; set; }
        /*
        Lieu qui porte un nom rappelant une particularité topographique ou historique et qui, souvent, constitue un écart d'une commune (un écart est une petite agglomération distincte du centre de la commune à
        laquelle elle appartient).
        */
        [MaxLength(40)]
        [Display(Name = "Lieu dit")]
        public  LieuDit LieuDit { get; set; }
        /*
        Mentions particulières de distribution. 
        Il s'agit de mentions identifiant le service proposé par La Poste au destinataire. 
        Ces mentions sont formées d'un libellé et d'un numéro de séparation (exemple : BP 42534).
        */
        [MaxLength(9)]
        [Display(Name = "Mention")]
        public string Mention { get; set; }
        /*
        Code Postal : Code Postal ou code postal spécifique CEDEX
        * Code postal: Un code à 5 chiffres servant à l'acheminement et/ou à la distribution des envois. 
        Il identifie un bureau distributeur dans la chaîne de traitement du courrier.
        * Code CEDEX (Courrier d'Entreprise à Distribution Exceptionnelle); le CEDEX est une modalité d'acheminement du courrier associée à des services particuliers de distribution offerts aux entreprises
        caractérisées par un adressage spécifique; 
        le code postal spécifique  CEDEX est un code attribué aux organismes, entreprises, services  publics recevant un fort trafic. 
        Il identifie un client ou un ensemble de clients. 
        Il est positionné aux lieu et place du code postal général dans le cas des adresses CEDEX. 
        Ainsi, un code peut être associé à un client  (code individuel) ou partagé entre plusieurs clients (code collectif).
        Mise en correspondance FHIR R4: Address.postalCod
        */
        [MaxLength(5)]
        [Display(Name = "Code Postal")]
        public CodePostal CodePostal { get; set; }
        /*
        Localité ou Libellé du bureau distributeur CEDEX
        ** Localité: Zone d'habitation, en général la commune d'implantation du destinataire. 
        Elle est identifiée par son libellé INSEE sauf dans quelques cas où le libellé postal diffère du libellé INSEE, 
        généralement pour lever des ambiguïtés.
        ** Libellé du bureau distributeur CEDEX.
        Libellé du bureau distributeur c'est-à-dire (dans la très grande majorité
        des cas) le libellé de la commune siège du bureau CEDEX; la mention
        CEDEX doit obligatoirement suivre le libellé du bureau CEDEX; dans le
        cas où il existe plusieurs bureaux CEDEX pour une même entité ou
        commune, chaque bureau CEDEX sera identifié par un numéro
        (exemple : ROUBAIX CEDEX 2); ce numéro correspond au numéro
        d'arrondissement dans le cas des villes à arrondissements, à un
        numéro d'ordre dans les autres cas.
        Mise en correspondance FHIR R4: Address.city
        */
        [MaxLength(38)]
        [Display(Name = "Localite")]
        public Localite Localite { get; set; }
        /*
        Code officiel géographique (COG), diffusé par l'INSEE, de la commune d'implantation du destinataire. 
        Ce code ne fait pas partie de la norme  NF Z 10-011 mais il correspond au libellé de l'attribut "localite" de la classe Adresse qui lui fait partie de la norme.
        Nomenclature(s) associée(s) :
        TRE_R13-CommuneOM
        */

        [Display(Name = "Commune")]
        public COGCommune COGCommune { get; set; }
        /*
        Pour les adresses internationales, une subdivision administrative d'un pays.
        Dans le cas d'une adresse étrangère, il peut être nécessaire d'identifier dans l'adresse l'état fédéré, la région, le canton, etc.
        Mise en correspondance FHIR R4: Address.state
        */
        [Display(Name = "Division teritoriale")]
        public InternationalDivisionTerritoriale InternationalDivisionTerritoriale { get; set; }
        /*
        Pour les adresses internationales, nom du pays du destinataire, de préférence en majuscules et en toutes lettres, dans la langue du pays d’expédition 
        ou dans une langue reconnue par le Comité Européen de Normalisation (CEN) : anglais, français, allemand pour les envois européens.
        Mise en correspondance FHIR R4: Address.country
        */
        [MaxLength(2)]
        [Display(Name = "Pays")]
        public PaysIso PaysIso { get; set; }
        /*
        Indique le ou les types d'adresse tel que "Adresse du domicile",
        "Adresse professionnelle", "Adresse de facturation", "Adresse postale",  "Adresse géographique", etc.
        Cet attribut ne fait pas partie de la norme NF Z 10-011.
        Mise en correspondance FHIR R4: Address.use
        //TODO Table de référence
        */
        //TODO mise à jour des propriétés
        [Display(Name = "Type Adresse ")]
        public TypeAdresse TypeAdresse { get; set; }
        /*
        Identité du destinataire
        La première ligne de l'adresse de publipostage est obtenue par
        assemblage des éléments d'identification du destinataire (personne
        physique ou morale).
        Cas particulier: pour un domicilié personne morale, la ligne 1 peut
        contenir l'identification du domicilié personne morale et la ligne 2
        contient l'identification du destinataire personne physique.
        38 caractères ou espaces par ligne au maximum.
        Mise en correspondance FHIR R4: Address.line
        */
        [NotMapped]
        [MaxLength(38)]
        [Display(Name = "Ligne 1 ")]
        public string Ligne1 { get; set; }
        /*
        La deuxième ligne de l'adresse de publipostage est obtenue par assemblage des éléments de:
        * point de remise
        * domicilié personne physique(exemple: chez M X)
        * domicilié personne morale
        Cas particulier: pour un domicilié personne morale, la ligne 1 peut
        contenir l'identification du domicilié personne morale et la ligne 2
        contient l'identification du destinataire personne physique.
        38 caractères ou espaces par ligne au maximum
        Mise en correspondance FHIR R4: Address.line
        */
        [NotMapped]
        [MaxLength(38)]
        [Display(Name = "Ligne 2 ")]
        public string Ligne2 { get; set; }
        /*
        La troisième ligne de l'adresse de publipostage est obtenue par assemblage des éléments de complément de l'adresse au point géographique.
        38 caractères ou espaces par ligne au maximum.
        Mise en correspondance FHIR R4: Address.line
        */
        [NotMapped]
        [MaxLength(38)]
        [Display(Name = "Ligne 3 ")]
        public string Ligne3 { get; set; }
        /*
        La quatrième ligne de l'adresse de publipostage est obtenue par assemblage des éléments d'adresse: Numéro dans la voie + Extension + Libellé de la voie.
        38 caractères ou espaces par ligne au maximum.
        Mise en correspondance FHIR R4: Address.line
        */
        [NotMapped]
        [MaxLength(38)]
        [Display(Name = "Ligne 4 ")]
        public string Ligne4 { get; set; }
        /*
        La cinquième ligne de l'adresse de publipostage est obtenue par assemblage des éléments d'adresse:
        * Mentions particulières de distribution suivies du libellé de la localité de destination dans le cas où celle-ci serait différente du libellé cedex
        * Lieu-dit.
        38 caractères ou espaces par ligne au maximum.
        Mise en correspondance FHIR R4: Address.line
        */
        [NotMapped]
        [MaxLength(38)]
        [Display(Name = "Ligne 5 ")]
        public string Ligne5 { get; set; }
        /*
        La sixième ligne de l'adresse de publipostage obtenue par assemblage  des éléments d'adresse: Code postal + localité de destination ou code
        cedex + libellé bureau cedex.
        38 caractères ou espaces par ligne au maximum.
        Mise en correspondance FHIR R4: Address.line
        */
        [NotMapped]
        [MaxLength(38)]
        [Display(Name = "Ligne 6 ")]
        public string Ligne6 { get; set; }
        /*
        La septième ligne de l'adresse de publipostage contient, pour les envois à l'international, dans tous les cas, le nom du pays du destinataire, de préférence en majuscules et en toutes lettres, dans la
        langue du pays d’expédition ou dans une langue reconnue par le
        Comité Européen de Normalisation(CEN) : anglais, français, allemand pour les envois européens.
        Mise en correspondance FHIR R4: Address.line
        */
        [NotMapped]
        [MaxLength(38)]
        [Display(Name = "Ligne 7 ")]
        public string Ligne7 { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //
        public string ContactId { get; set; }
        public Contact Contact { get; set; }

        public string LieuId { get; set; }
        public Lieu Lieu { get; set; }

        public string ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; set; }

        public string PersonnePriseChargeId { get; set; }
        public PersonnePriseCharge PersonnePriseCharge { get; set; }

        public string SituationEnExerciceId { get; set; }
        public SituationEnExercice SituationEnExercice { get; set; }

        //GROUPE STRUCTURE
        public string EntiteJuridiqueId { get; set; }
        public EntiteJuridique EntiteJuridique { get; set; }

        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }

        //ORGANISATION
        public string OrganisationInterneId { get; set; }
        public OrganisationInterne OrganisationInterne { get; set; }
    }
}
