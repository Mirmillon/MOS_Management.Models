using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromTelecommunication;
using MOS_Management.Models.CLassesMos.FromTexte;
using MOS_Management.Models.ProfessionnelDossier;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.ClassesCommunes
{
    public class BoileLettreMMS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BoileLettreMMSId { get; set; }
        /*
        Adresse unique de messagerie sécurisée dans un domaine de messagerie MSSanté.
        */
        public Messagerie Messagerie { get; set; }
        /*
        Type de boîte aux lettres.
        Valeurs possibles :
        ** ORG pour une BAL organisationnelle
        ** APP pour une BAL applicative
        ** PER pour une BAL personnelle, rattachée à une personne physique
        Une BAL de type ORG ou APP est rattachée à une personne morale (entité
        géographique ou entité juridique) et son usage s’effectue sous la responsabilité
        d’un ou plusieurs professionnels habilités à échanger des données de santé
        personnelles.
        Nomenclature(s) associée(s) :
        TRE_R257-TypeBAL
        */
        [MaxLength(3)]
        [Display(Name = "Type BAL")]
        public TypeBAL TypeBAL { get; set; }
        /*
        Description fonctionnelle de la boîte aux lettres.
        */
        [MaxLength(75)]
        [Display(Name = "fonction B.A.L")]
        public Commentaire Description { get; set; }
        /*
        Texte libre donnant les coordonnées de la (ou des) personne(s) responsable(s) au niveau opérationnel de la boîte aux lettres. 
        Non renseigné pour les types de boîte aux lettres "PER".
        */
        //TODO conditionnel
        [MaxLength(45)]
        [Display(Name = "Personne responsable")]
        public string Responsable { get; set; }
        /*
        Nom et description du service de rattachement de l’utilisateur de la boîte aux lettres dans l’organisation.
        */
        [MaxLength(90)]
        [Display(Name = "Service de rattachement")]
        public string ServiceRattachement { get; set; }
        /*
        Coordonnées téléphoniques spécifiques à l’usage de la boîte aux lettres MSSanté.
        */
        public Telephonne Telephonne { get; set; }
        /*
        Indicateur d’acceptation de la dématérialisation (ou « Zéro papier »).
        Un utilisateur peut porter à la connaissance des autres utilisateurs du système  MSSanté, via l’Annuaire national MSSanté son souhait de ne plus recevoir par  voie papier des documents d’ores et déjà reçus par voie électronique dans le cadre du système MSSanté.
        Cette option s’applique également pour les BAL applicatives ou         organisationnelles.
        Valeurs possibles :
        - O : Dématérialisation acceptée
        - N : Dématérialisation refusée
        */
        //TODO condiotionnel
        [Display(Name = "Acceptation dématérialisation ")]
        public bool? Dematerialisation { get; set; }
        /*
        Indicateur liste rouge
        Valeurs possibles :
        ** O: Boîte aux lettres en liste rouge
        ** N: La boîte aux lettres peut être publiée
        */
        [Display(Name = "Liste Rouge ")]
        public bool? ListeRouge { get; set; }

        public BoileLettreMMS()
        {
            ListeRouge = true;
            Dematerialisation = true;
        }

        public MetaDonnee MetaDonnee { get; set; }

        //
        public string ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; set; }


    }
}
