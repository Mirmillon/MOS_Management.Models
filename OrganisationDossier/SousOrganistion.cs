using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
//Table reflexive
namespace MOS_Management.Models.OrganisationDossier
{
    [NotMapped]
    public class SousOrganisation
    {
       
        public string OrganisationId { get; set; }

        public string DependanceId { get; set; }
    }
}
