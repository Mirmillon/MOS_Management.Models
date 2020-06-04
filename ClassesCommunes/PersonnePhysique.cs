using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.CLassesMos;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.CLassesMos.FromTexte;
using MOS_Management.Models.TypeDonnées.Complexes;
using MOS_Management.Models.TypeDonnées.Simple;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//Une personne physique est un individu titulaire de droits et d'obligations caractérisé par une identité civile.

namespace MOS_Management.Models.ClassesCommunes
{
    [Mos]
    public class PersonnePhysique
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PersonnePhysiqueId { get; set; }
        [Mos]
        [Display(Name = "Civilité")]
        public Civilite Civilite { get; set; }//FK
        [Mos]
        [Required]
        [Display(Name = "Nom de naissance")]
        public NomNaissance NomNaissance { get; set; }
        [Mos]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        [Display(Name = "Date Naissance ")]
        public string DatenNeissance { get; set; }
        [Mos]
        [Display(Name = "Date Décès ")]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        public string DateDeces { get; set; }
        //Pas dans le schéma
        [Display(Name = "En vie")]
        public bool EnVie { get; set; }
        [Mos]
        [Display(Name = "Premom d'usage")]
        public string PrenomUsageId { get; set; }
        [Mos]
        [Display(Name = "Nom d'usage")]
        public NomUsage NomUsage { get; set; }
        [Mos]
        [Display(Name = "Genre")]
        public Genre Genre { get; set; }//FK
        [Mos]
        [Display(Name = "Genre Civil")]
        public GenreCivil GenreCivil { get; set; }//FK
        [Mos]
        [Display(Name = "Genre(norme ISO)")]
        public GenreIso GenreIso { get; set; }//FK
        [Mos]
        [Display(Name = "Situation familiale")]
        public SituationFamiliale SituationFamiliale { get; set; }//PK
        [Mos]
        [Display(Name = "Categoriesocio Professionnelle")]
        public CategorieSocioProfessionnelle CategorieSocioProfessionnelle { get; set; }//PK
        [Mos]
        [Display(Name = "Commune de naissance")]
        public Commune Commune { get; set; }
        [Mos]
        [Display(Name = "Pays de Naissance ")]
        public string  PaysNaissanceId { get; set; }//PK
        [Mos]
        [Display(Name = "Pays de Résidence ")]
        public string  PaysResidenceId { get; set; }//PK
        [Mos]
        [Display(Name = "Pays de Nationalité ")]
        public string  PaysNationaliteId { get; set; }//PK
        [Mos]
        [Display(Name = "Pays de Nationalité CodeIso")]
        public PaysIso PaysIso { get; set; }//PK
        [Mos]
        //Statut de la demande de certification auprès de l'organisme certificateur
        public StatutEtatCivil StatutEtatCivil { get; set; }//FK
       //Date de transmission du statut d’état civil de la personne par l’organisme certificateur d’état-civil.
        [Display(Name = "Date Transmission ")]
        [DataType(DataType.Text)]
        [MaxLength(45)]
        public string DateTransmission { get; set; }
        [Mos]
        //date acquisition nationalite française
        [Display(Name = "Date Acquisition NF ")]
        [DataType(DataType.Date)]
        public MosDateTime Dnf { get; set; }
        [Mos]
        public Mesure TailleId { get; set; }
        [Mos]
        public Mesure PoidsId { get; set; }
        [Mos]
        public CauseMortalite CauseMortalite {get; set;}//FK
        [Mos]


        public List<LangueParlee> LangueParlees { get; set; }
        public List<PrenomNaissance> Prenoms { get; set; }
     

        public PersonnePhysique()
        {
            EnVie = true;
        }
        [Mos]
        public Mesure SurfaceCorporelle
        {
            get
            {
                /*
                if ((poids > 40 && age > 10) || (poids < 40 && age > 10) && taille > 0)
                {
                    //TODO VERIFICATION FOORMULE BOYD pour la surface corporelle
                    //La surface corporelle est calculée selon la formule suivante(Formule de BOYD) :
                    //SC = 0,0001 x(3, 207) x(P0, 7285 - 0, 0188logP) x(T0, 3) avec T en cm, P en grammes et Log le logarithme décimal.
                    return 0.0001 * 3.207 * ((poids * 1000));
                }
                else if (poids < 40)
                {
                    //SC = (4 x P + 7) / (P + 90) avec P en Kg, le résultat SC est donné en metre carrée
                    return (4 * poids + 7) / (taille + 90);
                }
                else
                */
                {
                    return null;
                }
            }

        }
        [Mos]
        [DataType(DataType.Text)]
        public Mesure Imc
        {
            
            get
            {

                return null;

            }
        }

        public Mesure Age
        {
            get
            {
                return null;
            }
        }
        [Mos]
        public CategorieAge CategorieAge
        {
            /*
            1.2.250.1.213.3.3.9;01;Nouveau né, jusqu'à 28 jours;Nouveau né, <= 28 jr;Nouveau né, jusqu'à 28 jours;20150408000000;;20160901000000
            1.2.250.1.213.3.3.9;02;Nourrisson, avant 2 ans;Nourrisson, < 2 ans;Nourrisson, avant 2 ans;20150408000000;;20160901000000
            1.2.250.1.213.3.3.9;03;Enfant, avant 12 ans;Enfant, < 12 ans;Enfant, avant 12 ans;20150408000000;;20160901000000
            1.2.250.1.213.3.3.9;04;Adolescent, avant 16 ans;Adolescent, < 16 ans;Adolescent, avant 16 ans;20150408000000;;20160901000000
            1.2.250.1.213.3.3.9;05;Jeune adulte, 16-21 ans;Adulte, 16-21 ans;Jeune adulte, 16-21 ans;20150408000000;;20160901000000
            1.2.250.1.213.3.3.9;06;Adulte, avant 65 ans;Adulte, < 65 ans;Adulte, avant 65 ans;20150408000000;;20160901000000
            1.2.250.1.213.3.3.9;10;Sénior, 65-75 ans;Sénior, 65-75 ans;Sénior, 65-75 ans;20160901000000;;20160901000000
            1.2.250.1.213.3.3.9;11;Sénior, 75 ans et plus;Sénior, > 75 ans;Sénior, 75 ans et plus;20160901000000;;20160901000000
            */
            //TODO ecire méthode qui compare les dates en fonction du jour du mois + 2 ans
            //sera plus précis


            get
            {
                /*
                int nbJours = DateTime.Today.Subtract(Ddn).Days; ;
                if (nbJours < 29)
                {
                    return "Nouveau-Né";
                }
                else if ((nbJours > 28) && (nbJours < 730))
                {
                    return "Nourisson";
                }
                else if ((nbJours > 729) && (nbJours < 4380))
                {
                    return "Enfant";
                }
                else if ((nbJours > 4379) && (nbJours < 5840))
                {
                    return "Adolescent";
                }
                else if ((nbJours > 5839) && (nbJours < 7665))
                {
                    return "Jeune Adulte";
                }
                else if ((nbJours > 7664) && (nbJours < 23725))
                {
                    return "Adulte";
                }
                else if ((nbJours > 23724) && (nbJours < 27375))
                {
                    return "Sénior 65-75";
                }
                else
                {
                    return "Sénior, 75 ans et plus";
                }
                */
                return null;
            }
        }

    }
}
