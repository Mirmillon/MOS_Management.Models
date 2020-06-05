using MOS_Management.Models.AuthentificationDossier;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOS_Management.Models.ClassesCommunes
{
    public class ObjetBinaire
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ObjetBinaireId { get; set; }

        public String Valeur { get; set; }

        public String Format { get; set; }

        public String Mime { get; set; }

        public String Encodage { get; set; }

        public String URI { get; set; }

        public String NomFichier { get; set; }

        //
        public string CertificatId { get; set; }
        public Certificat Certificat { get; set; }
    }
}
