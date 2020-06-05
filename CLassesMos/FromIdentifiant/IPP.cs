using MOS_Management.Models.ProfessionnelDossier;
using MOS_Management.Models.TypeDonnées.Complexes;
using System;
using System.Collections.Generic;
using System.Text;
/*
Identifiant
Identification nationale principale du professionnel initiée pour les besoins du SI-CPS.
Cette identification est obtenue par la concaténation du type d'identifiant national de personne (provenant de la nomenclature TRE_G08-TypeIdentifiantPersonne) et
de l'identifiant de la personne physique provenant, 
selon le type d’identifiant, soit d’un référentiel national, soit d’un référentiel local propre à la structure d’exercice de la personne physique:
*/
namespace MOS_Management.Models.CLassesMos.FromIdentifiant
{
    public class IPP : Identifiant
    {
        public string ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; set; }
    }
}
