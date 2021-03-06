﻿using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class NiveauConfidentialite :Code
    {
        public string TeleCommunicationId { get; set; }
        public TeleCommunication TeleCommunication { get; set; }

        public string ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
