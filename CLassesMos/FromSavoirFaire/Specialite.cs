﻿




using MOS_Management.Models.ProfessionnelDossier;
using System.ComponentModel.DataAnnotations;

/*
 ** Classe spécialisée, hérite de: SavoirFaire
Spécialité médicale ou odontologique, reconnue par une autorité d'enregistrement (Ordre ou SSA), soit sur la base d'un diplôme de spécialité (DES ou DESC de groupe II, CES jusqu'en 1991), soit via une commission de qualification.
En France, l'exercice d'une spécialité est exclusif, c'est-à-dire qu'on ne peut exercer qu'une seule spécialité, celle qui fait l'objet d'une qualification par le Conseil de l'ordre. Un médecin titulaire d'un DESC de type II qui s'ajoute à son DES, a donc 2 qualifications possibles. 
Lorsqu'il s'inscrit au tableau de l'ordre des médecins, il doit déclarer sa spécialité d'exercice. 
S'il choisit celle de son DESC, il ne peut pas exercer la spécialité de son DES. 
Toutefois, il peut, dans le futur, choisir le retour à la spécialité originelle portée par le DES.
Ainsi, la création en 2004 du DESC de Gériatrie a marqué la naissance de la qualification de spécialiste en gériatrie (la gériatrie étant auparavant un mode d'exercice particulier de la médecine, concernant des généralistes et des spécialistes).
Dans le cadre du modèle, une spécialité est un type de savoir-faire. 
La classe Specialite est représentée dans le modèle comme une spécialisation de la classe SavoirFaire et à ce titre, elle hérite des attributs et des associations de cette classe.
*/

namespace MOS_Management.Models.CLassesMos.FromSavoirFaire
{
    public class Specialite : SavoirFaire
    {
        

    }
}
