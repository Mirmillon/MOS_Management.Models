
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
Equipement ou dispositif médical utilisé pour la réalisation d'une activité de soin ou le suivi du
patient (objet connecté, équipement de diagnostic, etc.)
*/

namespace MOS_Management.Models.ClassesCommunes
{
    public  class RessourceMaterielle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string RessouceMaterielleId { get; set; }
        /*
        Libellé de l'équipement.
        */
        public string Libelle { get; set; }
        /*
        Référence de l'équipement.
        */
        public string Reference { get; set; }

        //
        public string EntiteGeographiqueId { get; set; }
        public EntiteGeographique EntiteGeographique { get; set; }




    }
}
