
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromIdentifiant;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.Autorisation
{
    public class DisciplineSocialeAutorisee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string DisciplineSocialeAutoriseeId { get; set; }
        /*
        Identifiant fonctionnel de l'autorisation de la discipline sociale en question.
        */
        [MaxLength(20)]
        [Display(Name = "Identifiant")]
        public CLassesMos.FromIdentifiant.Autorisation Autorisation { get; set; }
        /*
        Date de délivrance de l'autorisation de la discipline sociale donnée à l'établissement.
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Autorisation")]
        public string DateAutorisation { get; set; }
        /*
        La discipline désigne une activité qui est fonction du type de soin ou de service.
        Elle est caractérisée par des équipements spécifiques et des personnels qualifiés. 
        Un  seul de ces deux éléments suffit à préciser la discipline.
        Synonyme : discipline d'équipement
        Nomenclature(s) associée(s) :
        TRE_R280-DisciplineEquipementSocial
        */
        [MaxLength(3)]
        [Display(Name = "Discipline")]
        public Discipline Discipline { get; set; }
        /*
        Le fonctionnement décrit la manière dont le client est pris en charge par l'établissement auquel il s'adresse. 
        Il caractérise le mode d'accueil des établissements sociaux et médico-sociaux (hébergement complet, semi-internat, externat, etc).
        Synonyme : type d'activité
        Nomenclature(s) associée(s) :
        TRE_R209-TypeActivite
        */
        [MaxLength(3)]
        [Display(Name = "Activité")]
        public Fonctionnement Fonctionnement { get; set; }
        /*
        Clientèle accueillie au sein des établissements sociaux et médico-sociaux.
        Synonyme : patientèle
        Nomenclature(s) associée(s) :
        TRE_R279-ClienteleESMS
        */
        [MaxLength(3)]
        [Display(Name = "Clientele")]
        public Clientele Clientele { get; set; }

        public MetaDonnee MetaDonnee { get; set; }



       
      
    }
}
