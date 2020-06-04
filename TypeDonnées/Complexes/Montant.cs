using MOS_Management.Models.CLassesMos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.TypeDonnées.Complexes
{
    public class Montant
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public string MontantId { get; set; }
       public Devise Devise { get; set; }
       public string Valeur { get; set; }
    }
}
