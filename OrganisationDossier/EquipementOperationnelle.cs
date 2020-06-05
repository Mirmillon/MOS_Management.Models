
using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
/*
Un équipement est une ressource matérielle nécessaire à la réalisation d'une activité ou d'un acte
spécifique. Seuls les équipements pouvant être discriminants pour l’orientation sont indiquées. Ces
équipements sont des ressources propres de l’OI ou des ressources mises à disposition dans le
cadre d’une convention à la condition qu’elles interviennent sur site.
*/

namespace MOS_Management.Models.OrganisationDossier
{
    public class EquipementOperationnelle :RessourceMaterielle
    {
       
        /*
        Un type d'équipement correspond à une ressource matérielle médicotechnique
        spécialisée, qui permet la réalisation d’une activité de soins.
        Les équipements ordinaires utilisés pour réaliser les activités proposées par
        l'OI ne sont pas des équipements spécifiques.
        Les équipements spécifiques décrits sont des ressources propres de l’OI ou
        des ressources mises à disposition dans le cadre d’une convention à la
        condition que ces ressources soient utilisées au sein de l'OI (sur site).
        Nomenclature(s) associée(s) :
        TRE_R212-Equipement
        */
        [Display(Name = "Equipement")]
        public TypeEquipement TypeEquipement { get; set; }
        /*
        Nombre d'équipements du même type en état de fonctionnement.
        */
        public short NbEquipement { get; set; }

        public MetaDonnee MetaDonnee { get; set; }

        //RELATION DOSSIER
        public string OrganisationInterneId { get; set; }
        public OrganisationInterne OrganisationInterne { get; set; }



    }
}
