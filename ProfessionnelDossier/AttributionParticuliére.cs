

using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
Attribution particulière.
Par exemple : 
**Agrément : Autorisation d’un médecin généraliste ou spécialiste, formalisée par un agrément, à figurer sur une liste départementale établie par le Préfet sur proposition du directeur départemental de l'action sanitaire et sociale et après avis du conseil départemental de l'ordre des médecins et des syndicats départementaux des médecins. 
Nomenclature(s) associée(s) :
TRE_R03-AttributionParticuliere
*/

namespace MOS_Management.Models.ProfessionnelDossier
{
    public class AttributionParticuliére
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AttributionParticuliéreId { get; set; }

        [MaxLength(8)]
        [Display(Name = "Attribution Particuliere")]
        public TypeAttributionParticuliére TypeAttributionParticuliére { get; set; }

        //Date à partir de laquelle l'attribution particulière prend effet.
        [DataType(DataType.Date)]
        [Display(Name = "Début Attribution")]
        public DateTime? DateDebut { get; set; }

        //Date à laquelle le professionnel ne veut plus faire apparaître cette attribution.
        [DataType(DataType.Date)]
        [Display(Name = "FiN Attribution")]
        public DateTime? DateFin { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //RELATION DOSSIER PROFESSIONNEL D'APRES SCHEMA
        public string ExerciceProfessionnelId { get; set; }
        public ExerciceProfessionnel ExerciceProfessionnel { get; set; }
        //FIN RELATION




    }
}
