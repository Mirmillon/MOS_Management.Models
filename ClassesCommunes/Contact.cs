

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
Personne ou service qui agit comme point de contact auprès d'une autre personne ou d'un autre
service.
Exemple: Point de contact avec une personne ou une organisation (un guichet d'accueil, une
source d'information, etc.).
*/

namespace MOS_Management.Models.ClassesCommunes
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ContactId { get; set; }
        /*
        Un nom de la personne ou du service à contacter.
        */
        public string NomContact { get; set; }
        /*
        Un titre, une position ou une fonction de la personne assurant le contact au sein
        de son organisation (directeur, secrétaire, etc.).
        */
        public string Fonction { get; set; }
        /*
        Code du titre, de la position ou de la fonction de la personne assurant le contact
        au sein de son organisation (directeur, secrétaire, etc.).
        Nomenclature(s) associée(s) :
        TRE_R251-FonctionContact
        */
        public string FonctionContactId { get; set; }
        /*
        Un service ou un guichet assurant le contact au sein de l'organisation (accueil,
        admission, etc.).
        Nomenclature(s) associée(s) :
        TRE_R287-NatureContact
        */
        public string NatureContactId { get; set; }
        /*
        Une description du contact.
        */
        public string Description { get; set; }
        /*
        Type du point de contact, c'est à dire un téléservice, un point de contact physique
        (une personne), un contact téléphonique, etc.
        Nomenclature(s) associée(s) :
        TRE_R206-TypeContact
        */
        public string TypeContactId { get; set; }
        /*
        Date/heure à partir de laquelle le contact est effectif.
        */
        [Display(Name = "Début contact")]
        public DateTime? DateDebutcContact { get; set; }
        /*
        Date/heure à partir de laquelle le contact n'est plus effectif.
        */
        [Display(Name = "Début contact")]
        public DateTime? DateFinContact { get; set; }
        /*
        Le niveau de confidentialité permet de définir le niveau de restriction de l'accès
        aux attributs de la classe Contact.
        Nomenclature(s) associée(s) :
        TRE_R283-NiveauConfidentialite
        */
        public string NiveauConfidentialiteId { get; set; }
        /*
        Informations détaillées de la personne point de contact.
        */
        public PersonnePhysique PersonnePhysique { get; set; }
        /*
        Rôle de la personne point de contact auprès d'une autre personne. Exemple dans
        le cas d'un patient, ce rôle indique si le point de contact est la personne à
        prévenir en cas d'urgence, la personne de confiance, etc.
        Nomenclature(s) associée(s) :
        TRE_R260-HL7RoleClass
        */
        public string HL7RoleClassId { get; set; }
        /*
        Lien de la personne point de contact auprès d'une autre personne. Exemple dans
        le cas d'un patient, ce lien indique si le point de contact est son enfant, son frère,
        etc.
        Nomenclature(s) associée(s) :
        TRE_R216-HL7RoleCode
        */
        public string HL7RoleCodeId { get; set; }
        /*
        Adresse géopostale du point de contact.
        */
        public Adresse Adresse { get; set; }
        /*
        Lieu(x) rattaché(s) au contact.
        */
        //IEnumerable<Lieu> Lieuxs { get; set; }
        /*
        Adresse(s) de télécommunication du contact (numéro de téléphone, adresse
        email, URL, etc.).
        */
       

    }
}
