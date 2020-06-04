using MOS_Management.Models.ClassesCommunes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromTelecommunication
{
    public class Telephonne : TeleCommunication
    {
        public string BoileLettreMMSId { get; set; }
        public BoileLettreMMS BoileLettreMMS { get; set; }
    }
}
