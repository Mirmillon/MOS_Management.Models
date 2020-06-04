using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.TypeDonnées.Complexes
{
    public class Numerique
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string NumeriqueId { get; set; }

        public string Valeur { get; set; }

        //TODO Indique si la valeur numérique est un nombre entier, décimal, nombre réel.
        public string TypeValeur { get; set; }
    }
}
