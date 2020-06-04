using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos
{
    public class Devise : Code
    {
        public string MontantId { get; set; }
        public Montant Montant { get; set; }
    }
}
