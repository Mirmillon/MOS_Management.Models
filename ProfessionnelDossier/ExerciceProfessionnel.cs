

using MOS_Management.Models.AuthentificationDossier;
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
Informations décrivant notamment la profession exercée, l'identité d'exercice d'un professionnel et le cadre de son exercice (civil, militaire, etc.).
Il peut exister plusieurs exercices professionnels pour une personne à un instant donné.
Mise en correspondance FHIR R4: Practitioner pour civilité, nom et prénom d'exercice professionnel et PractitionerRole pour profession
*/

namespace MOS_Management.Models.ProfessionnelDossier
{
    public  class ExerciceProfessionnel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ExerciceProfessionnelId { get; set; }

        /*
        Civilité d’exercice du professionnel.
        Mise en correspondance FHIR R4: Practitioner.name (HumanName.suffix)
        Nomenclature(s) associée(s) 
        TRE_R11-CiviliteExercice
        */
        [MaxLength(2)]
        [Display(Name = "Civilite")]
        public CiviliteExercice CiviliteExercice { get; set; }

        /*
        Prénom sous lequel exerce le professionnel.
        Mise en correspondance FHIR R4: Practitioner.name (HumanName.given)
        */
        [MaxLength(30)]
        [Display(Name = "Prénom en exercice")]
        public string PrenomExercice { get; set; }

        /*
        Nom sous lequel exerce le professionnel.
        Mise en correspondance FHIR R4: Practitioner.name (HumanName.family)
        */
        [MaxLength(30)]
        [Display(Name = "Nom en exercice")]
        public string NomExercice { get; set; }

        /*
        Profession exercée ou future profession de l'étudiant.
        Mise en correspondance FHIR R4: PractitionerRole.code
        Nomenclature(s) associée(s) :
        TRE_G15-ProfessionSante
        TRE_R95-UsagerTitre
        TRE_R94-ProfessionSocial
        TRE_R291-AutreProfession
        Ces tables fusionnent dans l'objet TouteProfession
        */
        [MaxLength(4)]
        [Display(Name = "Profession")]
        public Profession Profession { get; set; }

        /*
        Indique le type de profession de la personne.
        Exemples :
        ** Professionnel de santé
        ** Usager de titre
        ** Professionnel secteur social
        ** etc.
        Nomenclature(s) associée(s) :
        TRE_R288-TypeProfession
        TRE_R37-TypeProfessionFonction
        Je choisis TR-37 
        */
        [MaxLength(2)]
        [Display(Name = "Categorie")]
        public TypeProfession TypeProfession { get; set; }

        /*
        Indique si le professionnel exerce sa profession en tant que :
        ** M: Militaire
        ** C: Civil
        ** F: Fonctionnaire 
        ** E: Etudiant
        L'autorité d'enregistrement du professionnel dépend de la catégorie de sa profession.
        Nomenclature(s) associée(s) :
        TRE_R09-CategorieProfessionnelle
        */
        [MaxLength(3)]
        [Display(Name = "Categorie")]
        public CategorieProfessionnelle CategorieProfessionnelle { get; set; }

        /*
        */
        [DataType(DataType.Date)]
        [Display(Name = "Début Exercice")]
        public DateTime? DateDebutExercice { get; set; }

        /*
        */
        [DataType(DataType.Date)]
        [Display(Name = "Fin Exercice")]
        public DateTime? DateFinExercice { get; set; }

        /*
        Code du département du premier référencement, pour un référencement de nature « inscription à l’ordre ».
        */
        [MaxLength(6)]
        [Display(Name = "Departement du premier référencement")]
        public DepartementOM DepartementOM { get; set; }

        public List<BoileLettreMMS> BoileLettreMMSs { get; set;  }

        public MetaDonnee MetaDonnee { get; set; }

        //RELATION DOSSIER PROFESSIONNEL D'APRES SCHEMA
        public string ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; set; }

        public List<SituationEnExercice> SituationEnExercices { get; set; }
        public List<SituationOperationnelle> SituationOperationnelles { get; set; }
        public List<SavoirFaire> SavoirFaires { get; set; }
        public List<NiveauFormation> NiveauFormations { get; set; }
        public List<AttributionParticuliére> AttributionParticuliéres { get; set; }
        //FIN RELATION

        //RELATION AUTRE DOSSIER
        public List<CarteProfessionnel> CarteProfessionnelles { get; set; }
        public List<Certificat> Certificats { get; set; }



    }
}