using MOS_Management.Models.CLassesMos.FromCode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.TypeDonnées.Complexes
{
    public class Mesure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MesureId { get; set; }
        //TODO Regex
        public string Valeur { get; set; }

        public Ucum Ucum { get; set; }
    }
}
