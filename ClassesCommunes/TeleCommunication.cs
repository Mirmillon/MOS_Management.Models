using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromTexte;
using MOS_Management.Models.PersonnePriseChargeDossier;
using MOS_Management.Models.ProfessionnelDossier;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MOS_Management.Models.ClassesCommunes
{
    [Mos]
    public class TeleCommunication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TeleCommunicationId { get; set; }

        //TRE_R200-CanalCommunication
        public Canal Canal { get; set; }

        //Valeur de l'adresse de télécommunication dans le format induit par le canal de communication, par exemple un numéro de téléphone, une adresse de courrier électronique, une adresse URL, etc.
        //Mise en correspondance FHIR R4: ContactPoint.value
        public AdresseTelecom AdresseTelecom { get; set; }

        public TypeMessagerie TypeMessagerie { get; set; }

        public NiveauConfidentialite NiveauConfidentialite { get; set; }

        public Utilisation Utilisation { get; set; }

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





    }
}
