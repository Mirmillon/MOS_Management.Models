using MOS_Management.Models.Autorisation;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class Discipline : Code
    {
        public string DisciplineSocialeAutoriseeId { get; set; }
        public DisciplineSocialeAutorisee DisciplineSocialeAutorisee { get; set; }
    }
}
