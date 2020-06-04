
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
/*
La classe Horaire permet de définir les différentes plages du planning d'une entité (jours et heures
d'ouverture, période de fermeture, etc.).
*/

namespace eSanteRazor.Models.MOS.Geographique
{
    public class Horaire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string  Id { get; set; }
        /*
        Un type de plage horaire apporte un contexte à la plage horaire définie par la
        suite. Un planning peut être constitué de plusieurs plages horaires du même type
        ou de types différents.
        Nomenclature(s) associée(s) :
        TRE_R252-TypeHoraire
        */
        [Display(Name = "Type Horaire")]
        public int? TypeHoraireId { get; set; }
        /*
        Indicateur d'ouverture ou de fermeture.
        Valeurs possibles :
        0 = Organisation fermée
        1 = Organisation ouverte
        */
        public bool? Ouvert { get; set; }
        /*
        Date effective de début de l'ouverture ou de la fermeture, cet attribut permet de
        caractériser les jours d'ouverture ou de fermeture exceptionnelle.
        */
        [Display(Name = "Début overture")]
        public DateTime? DebutOuverture { get; set; }
        /*
        Date effective de début de l'ouverture ou de la fermeture, cet attribut permet de
        caractériser les jours d'ouverture ou de fermeture exceptionnelle.
       */
        [Display(Name = "Début overture")]
        public DateTime? FinOuverture { get; set; }

        [MaxLength(150)]
        public string Commentaires { get; set; }


        public Horaire()
        {
            Ouvert = true;
        }



    }
}
