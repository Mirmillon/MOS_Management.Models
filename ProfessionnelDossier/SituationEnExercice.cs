using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.StructureDossier;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
Caractéristiques de l'exercice d’un professionnel pendant une période déterminée et dans une structure déterminée (à l'exception des remplaçants).
Synonymes : Activité (RPPS).
Mise en correspondance FHIR R4: PractitionerRole
*/

namespace MOS_Management.Models.ProfessionnelDossier
{
    public class SituationEnExercice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SituationEnExerciceId { get; set; }
        /*
        Fonction du professionnel au sein de la structure d’exercice. Par exemple,
        ** Titulaire de cabinet;
        ** Titulaire d’officine;
        ** Médecin scolaire;
        ** etc.
        Mise en correspondance FHIR R4: PractitionerRole.code
        Nomenclature(s) associée(s) :
        TRE_R21-Fonction
        TRE_R96-AutreFonctionSanitaire
        TRE_R85-RolePriseCharge
        Tablefusion
        */
        //maslenght 6
        [MaxLength(6)]
        [Display(Name = "Fonction")]
        public Fonction Fonction { get; set; }
        /*
        Indique le type de fonction du professionnel au sein de la structure d’exercice.
        Nomenclature(s) associée(s) :
        TRE_R289-TypeFonction
        TRE_R37-TypeProfessionFonction
         Tablefusion
        */
        [MaxLength(6)]
        [Display(Name = "Type Fonction")]
        public TypeFonction TypeFonction { get; set; }
        /*
        Le mode d'exercice décrit selon quelle modalité une activité est exercée au regard de l'organisation de la rétribution
        du professionnel.
        Exemples :
        ** Libéral;
        ** Salarié;
        ** Bénévole.
        Les valeurs de ce code sont répertoriées dans la nomenclature TRE_R23-ModeExercice.
        Nomenclature(s) associée(s) :
        TRE_R23-ModeExercice
        */
        [MaxLength(2)]
        [Display(Name = "Mode Exercice")]
        public ModeExercice ModeExercice { get; set; }
        /*
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Debut Activite")]
        public DateTime? DateDebutActivite { get; set; }
        /*
        Le genre d'activité identifie les activités qui nécessitent l’application de règles de gestion spécifiques, par exemple,
        activité standard de soins ou de pharmacien, activité non soignante, activité non médicale, etc.
        Nomenclature(s) associée(s) :
        TRE_R22-GenreActivite
        */
        [MaxLength(6)]
        [Display(Name = "Genre Activité")]
        public GenreActivite GenreActivite { get; set; }
        /*
        */
        [DataType(DataType.Date)]
        [Display(Name = "Date Fin Activite")]
        public DateTime? DateFinActivite { get; set; }
        /*
        Motif de fin d'activité, par exemple:
        ** Décès;
        ** Retraite libérale;
        ** Changement de profession;
        ** etc.
        Nomenclature(s) associée(s) :
        TRE_R25-MotifFinActivite
        */
        [MaxLength(3)]
        [Display(Name = "Motif Fin Activite")]
        public MotifFinActivite MotifFinActivite { get; set; }
        /*
        Statut hospitalier dans le cas d’une activité exercée en établissement public de santé, par exemple:
        ** Professeur des universités - praticien hospitalier (PU-PH);
        ** Assistant hospitalier universitaire (AHU);
        ** etc.
        Nomenclature(s) associée(s) :
        TRE_R32-StatutHospitalier
        */
        [MaxLength(6)]
        [Display(Name = "Statut Hospitalier")]
        public StatutHospitalier StatutHospitalier { get; set; }
        /*
        Section du tableau de l’Ordre des pharmaciens, par exemple:
        ** Pharmacien titulaire d’officine;
        ** Pharmacien biologiste;
        ** etc.
        Nomenclature(s) associée(s) :
        TRE_R06-SectionTableauCNOP
        */
        [MaxLength(2)]
        [Display(Name = "Section")]
        public SectionTableau SectionTableau { get; set; }
        /*
        Sous-section ou à défaut section du tableau de l’Ordre des pharmaciens.
        Nomenclature(s) associée(s) :
        TRE_G05-SousSectionTableauCNOP
        */
        [MaxLength(3)]
        [Display(Name = "Sous Section")]
        public SousSection SousSection { get; set; }
        /*
        Type d’activité libérale, par exemple:
        ** Cabinet;
        ** Secteur privé à l'hôpital;
        ** etc.
        Nomenclature(s) associée(s) :
        432-TypeActiviteLiberale
        */
        [MaxLength(12)]
        [Display(Name = "Type Activite Liberale")]
        public TypeActiviteLiberale TypeActiviteLiberale { get; set; }
        /*
        Statut du professionnel du Service de santé des armées, par exemple:
        ** Praticien certifié;
        Table 18 Attributs de la classe "SituationExercice"
        ** Praticien confirmé;
        ** etc.
        Nomenclature(s) associée(s) :
        TRE_R34-StatutProfessionnelSSA
        */
        [MaxLength(12)]
        [Display(Name = " Statut du Service de santé des armées")]
        public StatutProfessionnelSSA StatutProfessionnelSSA { get; set; }


        public List<TeleCommunication> Telecommunications { get; set; }
        public List<Adresse> Adresses { get; set; }
        public List<BoileLettreMMS> BoiteLettreMMs { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //RELATION DOSSIER PROFESSIONNEL D'APRES SCHEMA
        public string ExerciceProfessionnelId { get; set; }
        public ExerciceProfessionnel ExerciceProfessionnel { get; set; }
        //FIN RELATION

        //RELATION AUTRE DOSSIER
        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }




    }
}
