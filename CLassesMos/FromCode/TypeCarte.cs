using MOS_Management.Models.AuthentificationDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class TypeCarte : Code
    {
        public string CarteProfessionnelleId { get; set; }
        public CarteProfessionnelle CarteProfessionnelle { get; set; }

        public string CertificatId { get; set; }
        public Certificat Certificat { get; set; }

    }
}
