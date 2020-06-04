using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos
{
    public class Langue : Code
    {
        public string TexteId { get; set; }
        public Texte Texte { get; set; }

        public string LangueParleeId { get; set; }
        public LangueParlee LangueParlee { get; set; }
    }
}
