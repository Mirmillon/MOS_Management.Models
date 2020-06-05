


using MOS_Management.Models.ClassesCommunes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*
Le niveau de formation décrit le niveau de formation de l’étudiant, 
comme demandé par le décret n°2010-701 et complété par le décret n°2011-462.*/

namespace MOS_Management.Models.ProfessionnelDossier
{
    public class NiveauFormation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string NiveauFormationId { get; set; }

        /*
        Diplôme acquis pour les cycles terminés (cas des diplômes de deuxième cycle pour étudiants qui font un troisième cycle)
        ou diplôme préparé pour les cycles en cours.
        */
        public Diplome Diplome { get; set; }

        /*
        Nature du cycle de formation:
        - Deuxième cycle,
        - Troisième cycle court,
        - Troisième cycle long/Internat.
        Nomenclature(s) associée(s) :
        TRE_R223-NatCycleForm
        */
        [MaxLength(6)]
        [Display(Name = "Nature formation")]
        public string NatureFormationId { get; set; }

        /*
        Niveau de validité dans le cycle de formation.
        Nomenclature(s) associée(s) :
        TRE_R224-NiveauFormAcquis
        */
        [MaxLength(3)]
        [Display(Name = "Niveau formation")]
        public string TypeNiveauFormationId { get; set; }

        /*
        Année universitaire, exemple : 2015-2016.
        Nomenclature(s) associée(s) :
        TRE_R225-AnneeUniversitaire
        */
        [MaxLength(6)]
        [Display(Name = "Année Universitaire")]
        public string AnneeUniversitaireId { get; set; }

        //Date à laquelle le niveau de formation n’est plus actif (non visible hormis dans les données historisées). 
        //Cette date est renseignée par l’ordre à la clôture de l’exercice professionnel.
        [DataType(DataType.Date)]
        [Display(Name = "Fin Niveau formation")]
        public DateTime? DateFin { get; set; }

    }
}
