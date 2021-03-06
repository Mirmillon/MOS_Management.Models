﻿

using MOS_Management.Models.ProfessionnelDossier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*
Extrait du rapport de l'ONDPS sur la médecine générale (Tome 1 2006-2007): "La compétence était un titre délivré par l’ordre national
des médecins en application du précédent règlement de qualification (Article 3 de l'arrêté du 4 septembre 1970), aux praticiens dits
«ancien régime» ayant débuté leurs études médicales avant la réforme de 1982. Ce titre était accordé après avis d’une commission
ordinale spécifique. Les compétences, dont la liste était fixée par arrêté, portaient soit sur des disciplines ne correspondant pas à des
spécialités qualifiantes (médecine légale ou allergologie par exemple), soit sur des spécialités médicales, le praticien compétent ne
pouvant l’exercer que dans le cadre de sa spécialité d’inscription à l’ordre.
Les compétences ne peuvent plus être délivrées aux médecins issus du nouveau régime, c’est-à-dire ayant débuté leurs études à compter
de l’année universitaire 1984-1985. Toutefois, pour ceux de l’ancien régime et à titre transitoire, le dépôt d’une demande de qualification
était possible jusqu’au 31 décembre 2004 et ces praticiens peuvent s’en prévaloir jusqu’à la fin leur période d’activité professionnelle.
Une compétence est un type de savoir-faire. La classe Competence est représentée dans le modèle comme une spécialisation de la classe
SavoirFaire et à ce titre, elle hérite des attributs et des associations de cette classe.
*/
/*
	
Compétence acquise par le professionnel.
Mise en correspondance FHIR R4: PractitionerRole.specialty
*/

namespace MOS_Management.Models.CLassesMos.FromSavoirFaire
{ 
    public class Competence : SavoirFaire
    {
       
       
    }
}
