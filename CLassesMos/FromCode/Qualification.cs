using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class Qualification :Code
    {
        public string IdentifiantId { get; set; }
        public Identifiant Identifiant { get; set; }
    }
}
