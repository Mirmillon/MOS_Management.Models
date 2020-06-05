using MOS_Management.Models.ClassesCommunes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.AuthentificationDossier
{
    public class Certificat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CertificatId { get; set; }

        /*
        Numéro de série du certificat.
        Format de codage des caractères en binaire codé en ASCII.
        */
        //TODO  Format de codage des caractères en binaire codé en ASCII.

        [Display(Name = "Numéro Série")]
        public string NumeroSerie { get; set; }
        /*
        DN (Distinguished Name - Nom distinctif) de l’autorité de certification (AC)
        émettrice du certificat, le format respecte le standard RFC-4514, avec un codage
        des caractères en UTF8.
        */
        
        [Display(Name = "Nom de l’autorité de certification")]
        public string DNSujet { get; set; }
        /*
       Date et heure de début de validité de la carte. La date est en UTC (avec translation
       de l'heure locale en heure UTC par ajout du décalage négatif ou retranchement du
       décalage positif).
       */
        //TODO heure en UTC
        [DataType(DataType.Date)]
        [Display(Name = "Date Debut Validite")]
        public DateTime? DateDebutValidite { get; set; }
        /*
        Date et heure de fin de validité de la carte. La date est en UTC (avec translation de
        l'heure locale en heure UTC par ajout du décalage négatif ou retranchement du
        décalage positif).
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Fin Validite")]
        public DateTime? DateFinValidite { get; set; }
        /*
        La clé d’usage (Keyusage) qui détermine l’usage autorisé du certificat.
        Codage des caractères en binaire codé en ASCII.
        */
        //TODO  Codage des caractères en binaire codé en ASCII.
        [Display(Name = "Clé d'usage")]
        public string  Usage { get; set; }
        /*
        Renseigné uniquement pour les certificats logiciels de portée Structure. 
        Ce champ correspond au CN du DNSujet, il contient soit un "FQDN" pour les certificats de
        type serveur "SSL", soit un nom applicatif pour les autres certificats.
        */
        //TODO Contrainte usage à faire
        [Display(Name = "Domaine")]
        public string Domaine { get; set; }
        /*
        Adresse mail du professionnel ou de la structure, si présente dans le certificat (SUBALTNAME).
        */
        [Display(Name = " Adresse mail")]
        public TeleCommunication TeleCommunication { get; set; }
        /*
        Caractérise les modalités de mise en oeuvre de la clé privée et du certificat.
        Exemples :
        ** Carte de professionnel ou de personnel de santé
        Table 41 Attributs de la classe "Certificat"
        ** Module de sécurité
        ** Certificat logiciel
        Nomenclature(s) associée(s) :
        TRE_G01-CategorieProduit
        */
        [MaxLength(2)]
        [Display(Name = "Mise en oeuvre de la clé")]
        public string CategorieProduitId { get; set; }
        /*
        Type de carte renseigné obligatoirement pour les certificats embarqués dans les  cartes de professionnel (CPx).
        Exemples :
        ** Carte de Professionnel de Santé (CPS)
        ** Carte de Professionnel de santé en Formation (CPF)
        ** Carte de Personnel d’Etablissement (CDE/CPE)
        ** Carte de Personnel Autorisé (CDA/CPA)
        Nomenclature(s) associée(s) :
        TRE_R87-TypeCarte
        */
        [MaxLength(3)]
        [Display(Name = "Type Carte")]
        public string TypeCarteId { get; set; }
        /*
        Identification de l'émetteur du token complété du numéro de série de la carte.
        Cet attribut est renseigné obligatoirement pour les certificats embarqués dans les
        cartes CPS et optionnellement pour les modules de sécurité physique.
        Exemple : "8025000001/9999999999"
        '8025000001' : Identifiant national de l'ASIP Santé
        '9999999999' : N° de série de la carte sur 10 chiffres
        */
        [MaxLength(30)]
        [Display(Name = "Emetteur")]
        public string TokenId { get; set; }
        /*
        Valeur binaire du certificat (format .crt en hexadécimal, codé en ASCII).
        */
        //TODO format .crt en hexadécimal, codé en ASCII
        [MaxLength(300)]
        [Display(Name = "Valeur Binaire ")]
        public string Valeur { get; set; }
        /*
        Le statut de publication indique si l’autorisation a été donnée ou pas de publier le certificat dans l’annuaire de publication des certificats.
        */
        [MaxLength(30)]
        [Display(Name = "Publication ")]
        public string StatutPublication { get; set; }


       
    }
}
