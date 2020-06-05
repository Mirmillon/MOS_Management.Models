
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
L'Entité Juridique (EJ) correspond à la notion de personne morale :
** Pour les établissements sanitaires, sociaux, médico-sociaux et de formation aux professions de ces secteurs enregistrés dans le
FINESS, une EJ détient des droits (autorisations, agréments, conventions, etc.) lui permettant d'exercer ses activités dans des
établissements; chaque EJ dispose d'un statut juridique de la personne morale;
** Pour les autres types de structures, une EJ est une personne morale inscrite dans le SIRENE, identifiée par son numéro SIREN.
Mise en correspondance FHIR R4: Organization
Mise en correspondance SEMIC : Legal Entity
*/

namespace MOS_Management.Models.StructureDossier
{
    public class EntiteJuridique
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string EntiteJuridiqueId { get; set; }

        /*
        Identifiant FINESS de l'entité juridique attribué lors de sa création.
        Les personnes morales identifiées par des numéros FINESS sont également dotées de numéros SIREN. Le numéro
        FINESS étant porteur intrinsèquement de liens avec le domaine sanitaire ou le domaine médico-social, il est, s'il
        existe, à privilégier pour l’identification de ces personnes morales en tant qu’acteurs sanitaires et médico-sociaux
        (Référentiel d’identification des acteurs sanitaires et médico-sociaux - Politique Générale de Sécurité des Systèmes
        d’Information de Santé (PGSSI-S)).
        Le numéro FINESS est composé de 9 caractères numériques, tels que:
        ** Position 1-2 : numéro du département d'implantation ("2A", "2B" pour la Corse; "97" pour les départements
        d’Outre-mer; "98" pour Mayotte);
        ** Position 3 : "0";
        ** Position 4-8: "1" pour Guadeloupe, "2" pour Martinique, "3" pour Guyane, "4" pour Réunion, "5" pour Saint-Pierreet-
        Miquelon + numéro d'ordre de 4 chiffres;
        ** Position 4-8 : numéro d’ordre de 5 chiffres pour tous les autres départements;
        ** Position 9 : clé de Luhn calculée automatiquement.
        Mise en correspondance FHIR R4: Organization.identifier
        */
        [Display(Name = "Numéro FINESS")]
        [MaxLength(9)]
        public FINESS  Finess { get; set; }

        /*
        Le numéro SIREN est le numéro unique d'identification attribué à chaque entreprise ou organisme par l'INSEE.
        C'est un simple numéro d'ordre, composé de neuf chiffres:
        ** huit chiffres non significatifs (excepté pour les organismes publics où celui-ci commence obligatoirement par 1
        ou 2) complétés par une clé de Luhn.
        Il n'a aucun lien avec les caractéristiques de l'entreprise ou de l'organisme. Il est attribué une seule fois et n'est
        supprimé du répertoire qu'au moment de la disparition de la personne juridique (décès ou cessation de toute activité
        pour un entrepreneur individuel, dissolution pour une personne juridique).
        Mise en correspondance FHIR R4: Organization.identifier
        */
        [Display(Name = "Numéro SIREN")]
        [MaxLength(14)]
        public SIREN Siren { get; set; }

        /*
        Identification nationale de l'Entité juridique initiée pour les besoins du SI-CPS.
        Cette identification est obtenue par la concaténation du type d'identifiant national de structure (provenant de la
        nomenclature TRE_G07-TypeIdentifiantStructure) et de l'identifiant de la structure:
        ** 1 + N° FINESS (entité juridique et entité géographique indéterminées);
        ** 2 + N° SIREN.
        Cas particulier:
        La notion d’identifiant d'entité juridique n'a pas de sens métier pour un cabinet individuel ou un cabinet de groupe
        identifié par un RPPS-Rang ou un ADELI-rang (cf. Attibut IdenifiantEG de la classe EntiteGeographique). Si un cas
        d'usage nécessite d'appliquer la notion générique d'entité juridique et d'entité géographique pour un cabinet
        individuel ou un cabinet de groupe, alors l'identifiant de l'entité juridique est constitué de la façon suivante:
        ** pour le cabinet d’un PS ADELI : 0 + IdentifiantEJ;
        ** pour le cabinet d’un PS RPPS : 4 + IdentifiantEJ.
        Synonyme : Struct_IdNat (CI-SIS)
        Mise en correspondance FHIR R4: Organization.identifier
        */
        [Display(Name = "Identifiant National")]
        [MaxLength(16)]
        public IdentificationNationaleEntitéJuridique IdentificationNationaleEntitéJuridique { get; set; }

        /*
        Identifiant spécifique de l’entité juridique d’un cabinet individuel ou d’un cabinet de groupe dont l’entité géographique
        est identifiée par l’attribut identifiantEG. Pour information, cet identifiant est construit en reprenant l’identifiantEG
        précédé des caractère « EJ » (cf. Attribut IdentifiantEG de la classe EntiteGeographique).
        Synonyme : numEJ_RPPS_ADELI
        Mise en correspondance FHIR R4: Organization.identifier*/
        [Display(Name = "Identifiant Juridique")]
        [MaxLength(18)]
        public IdentifiantEntiteJuridique IdentifiantEntiteJuridique { get; set; }

        /*
        Type d’identifiant national de la structure.
        TRE_G07-TypeIdentifiantStructure
        */
        [MaxLength(50)]
        [Display(Name = "Identifiant Structure")]
        public IdentifiantNationalStructure IdentifiantNationalStructure { get; set; }

        /*
        La raison sociale est le nom de l'entité juridique.
        Elle figure obligatoirement dans les statuts de l'EJ.
        */
        [MaxLength(150)]
        [Display(Name ="Raison sociale")]
        public string RaisonSociale { get; set; }

        /*
        Raison sociale complète de l'entité juridique (acronymes, sigles ou abréviations développées).
        Mise en correspondance FHIR R4: Organization.alias
        */
        [MaxLength(300)]
        [Display(Name = "Raison sociale compléte")]
        public string RaisonSocialeComplet{ get; set; }

        [MaxLength(300)]
        [Display(Name = "Complément Raison Sociale")]
        public string ComplementRaisonSociale { get; set; }

        /*
        Chaque entité juridique dispose d'un statut juridique qui caractérise la situation juridique de la personne morale.
        La nomenclature des statuts juridiques est une notion propre à FINESS.
        Les statuts juridiques sont eux-mêmes classifiés en grands agrégats qui sont :
        ** Organismes et établissements publics:
        - Etat et collectivités territoriales;
        - Etablissements publics;
        ** Organismes privés:
        - Organismes privés à but non lucratif;
        - Organismes privés à caractère commercial;
        ** Personne morale de droit étranger.
        Mise en correspondance FHIR R4: Organization.type
        Nomenclature(s) associée(s) :
        TRE_R72-FinessStatutJuridique
        ASS_X11-FinessAgregatStatutJuridique
        */
        [MaxLength(150)]
        [Display(Name = "Statut Juridique")]
        public StatutJuridique StatutJuridique{ get; set;}

        /*
        Agrégat de statut juridique de niveau 1. L'agrégat de niveau 1 représente des regroupements d'agrégats de niveau 2.
        Par exemple, le code 1000 "Organismes et Etablissements publics" regroupe les codes d'agrégat de niveau 2 1100 et
        1200.
        Mise en correspondance FHIR R4: Organization.type
        Nomenclature(s) associée(s) :
        ASS_X11-FinessAgregatStatutJuridique
        TRE_R68-FinessAgregatStatutJuridiqueNiv1
        */
        [MaxLength(150)]
        [Display(Name = "Statut Juridique Niveau 1")]
        public StatutJuridiqueN1 StatutJuridiqueN1 { get; set; }

        /*
        Agrégat de statut juridique de niveau 2. L'agrégat de niveau 2 représente des regroupements d'agrégats de niveau 3.
        Par exemple, le code 1100 "Etat et Collectivités territoriales" regroupe les codes d'agrégats de niveau 3 1110 et
        1120.
        Mise en correspondance FHIR R4: Organization.type
        Nomenclature(s) associée(s) :
        ASS_X11-FinessAgregatStatutJuridique
        TRE_R69-FinessAgregatStatutJuridiqueNiv2
        */
        [MaxLength(150)]
        [Display(Name = "Statut Juridique Niveau 2")]
        public StatutJuridiqueN2 StatutJuridiqueN2 { get; set; }

        /*
        Agrégat de statut juridique de niveau 3. L'agrégat de niveau 3 représente des regroupements de statuts juridiques.
        Par exemple, le code 1120 "Collectivité territoriale" regroupe les statuts juridiques 02, 03 etc.
        Mise en correspondance FHIR R4: Organization.type
        Nomenclature(s) associée(s) :
        ASS_X11-FinessAgregatStatutJuridique
        TRE_R70-FinessAgregatStatutJuridique
        */
        [MaxLength(150)]
        [Display(Name = "Statut Juridique Niveau 3")]
        public StatutJuridiqueN3 StatutJuridiqueN3 { get; set; }

        /*
        Toute entité juridique et chacun de ses établissements (EG) se voit attribuer par l'Insee, lors de son inscription au
        répertoire SIRENE, un code caractérisant son activité principale par référence à la nomenclature d'activités française
        (NAF rév. 2). Plus précisément, on distingue le code APEN pour l'EJ.
        Nomenclature(s) associée(s) :
        TRE_R75-InseeNAFrev2Niveau5
        */
        [MaxLength(200)]
        [Display(Name = "Code APEN")]
        public Apen Apen { get; set; }

        /*
        Date de création de l'entité juridique.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Création")]
        public DateTime? DateCreation { get; set; }

        /*
         Date de fermeture de l'entité juridique.
         */
        [DataType(DataType.Date)]
        [Display(Name = "Date Fermeture")]
        public DateTime? DateFermeture { get; set; }

        /*
        Date de modification du numéro SIREN.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Modification Siren")]
        public DateTime? DateModificationSiren { get; set; }

        /*
        Origine/nature de la modification du SIREN (motif de modification de l’identifiant).
        */
        [Display(Name = "Motif de modification de l’identifiant SIREN")]
        [MaxLength(300)]
        public string origineModificationSIREN { get; set; }

        /*
        Type de fermeture de l'entité juridique, au sens des règles de gestion du SI FINESS (par exemple, fermeture
        définitive), obligatoire lors de la fermeture de l'entité.
        Nomenclature(s) associée(s) :
        TRE_R286-TypeFermeture
        */
        [Display(Name = "Motif fermeture")]
        public TypeFermeture TypeFermeture { get; set; }
      
        public Adresse Adresse { get; set; }

        public List<Contact> Contacts { get; set; }

        public List<TeleCommunication> TeleCommunications { get; set; }

        public List<BoileLettreMMS> BoileLettreMMSs { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        // RELATION STRUCTURE
        public List<EntiteGeographique> EntiteGeographiques { get; set; }
        //FIN RELATION

        //RELATION SCHEMA



    }
}
