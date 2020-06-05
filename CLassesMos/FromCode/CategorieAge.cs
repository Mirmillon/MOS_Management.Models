﻿using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class CategorieAge :Code
    {
        public string PersonnePhysiqueId { get; set; }
        public PersonnePhysique PersonnePhysique { get; set; }

        public string PatienteleId { get; set; }
        public Patientele Patientele { get; set; }
    }
}
