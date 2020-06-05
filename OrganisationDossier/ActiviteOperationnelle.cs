

using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.CLassesMos.FromCode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/*
Une activité opérationnelle est un ensemble cohérent d’actions et de pratiques mises en oeuvre
pour participer au rétablissement ou à l’entretien de la santé d’une personne. L’activité
opérationnelle peut être d’ordre médical ou sanitaire, à visée sociale, ou encore de l’ordre de
l’accompagnement dans le quotidien.
Mise en correspondance FHIR R4: HealthcareService
*/

namespace MOS_Management.Models.OrganisationDossier
{
    public class ActiviteOperationnelle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ActiviteOperationelleId { get; set; }
        /*
        Une activité opérationnelle est un ensemble cohérent d’actions et de
        pratiques mises en oeuvre pour répondre aux besoins en santé de la
        personne. Elle peut être d’ordre sanitaire, social ou médico-social. Cet
        ensemble opérationnel est plus détaillé qu’une activité soumise à
        autorisation préalable de l'ARS.
        Dans le secteur médico-social, chaque activité opérationnelle est
        rattachée à une famille d'activités (prestation niveau 4 de SERAFIN). Les
        activités opérationnelles décrites sont réalisées avec les ressources
        propres de l'organisation interne ou via des ressources mises à
        disposition dans le cadre d’une convention à la condition que ces
        ressources interviennent au sein de l'OI (sur site).
        Mise en correspondance FHIR R4: HealthcareService.specialty
        Nomenclature(s) associée(s) :
        TRE_R211-ActiviteOperationnelle
        ASS_A14-FamilleActivite-ActiviteOperationnelle
        */
        public Activite Activite{ get; set; }
        /*
        Une famille d’activités opérationnelles est un regroupement cohérent
        d’activités délivrées par une organisation interne, répondant à un besoin
        de la personne. Dans le secteur médico-social, la famille d’activités
        opérationnelles correspond au niveau 4 des prestations de la
        nomenclature SERAFIN.
        Mise en correspondance FHIR R4: HealthcareService.category
        Nomenclature(s) associée(s) :
        TRE_R266-FamilleActiviteOperationnelleHorsSerafin
        ASS_A14-FamilleActivite-ActiviteOperationnelle
        */
        public FamilleActivite FamilleActivite { get; set; }
        /*
        Date de mise en oeuvre de l'activité.
        */
        public DateTime? DateDebut { get; set; }
        /*
        Date fin de mise en oeuvre de l'activité.
        */
        public DateTime? DateFin { get; set; }

        public MetaDonnee MetaDonnee { get; set;  }

        //RELATION DOSSIER
        public List<Organisation_Activite> Organisation_Activites { get; set; }
        //FIN


    }
}
