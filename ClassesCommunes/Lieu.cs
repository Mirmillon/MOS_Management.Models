using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
//Informations relatives à une portion déterminée de l'espace, fixe ou mobile du point de vue de son affectation ou de ce qui s'y passe.
//Cas particulier de l'entité géographique : plusieurs lieux peuvent être associés à une même EG, ils peuvent décrire, à la fois, son addresse et des lieux spécifiques à l'EG.
//Mise en correspondance FHIR R4: Location

namespace MOS_Management.Models.ClassesCommunes
{
    public class Lieu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string LieuId { get; set; }

        public List<Identifiant> Identifiants  { get; set; }

        public string Nom { get; set; }

        public string Description  { get; set; }

        public TypeLieu TypeLieu { get; set; }

        public FonctionLieu FonctionLieu { get; set; }

        public AccessibiliteLieu AccessibiliteLieu { get; set; }

        public StatutLieu StatutLieu { get; set; }

        public COGCommune COGCommune { get; set; }

        public Adresse Adresse { get; set; }

        public CoordonneeGeographique CoordonneeGeographique { get; set; }

        public List<TeleCommunication> TeleCommunications { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //
        public string ContactId { get; set; }
        public Contact Contact { get; set; }

        public string ZoneId { get; set; }
        public Zone Zone { get; set; }
    }
}
