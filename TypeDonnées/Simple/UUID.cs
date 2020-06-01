using EHR_Management.Models.ProjectAttribute;
using System;
using System.Collections.Generic;
using System.Text;
/*
Universally Unique IDentifier (UUID), de l'anglais signifiant littéralement « identifiant universel unique », 
est en informatique un système permettant à des systèmes distribués d'identifier de façon unique une information sans coordination centrale importante. 
Dans ce contexte, le mot « unique » doit être pris au sens de « unicité très probable » plutôt que « garantie d'unicité ». 
Il s'agit d'une spécification DCE définie initialement par l'OSF (Open Software Foundation).

Cette spécification a été enrichie par la RFC 4122, en 2005, qui standardise des algorithmes de génération n'utilisant pas d'adresse matérielle. 
L'UUID est normalisé par l'ISO/IEC 9834-8:2008 qui prend en compte les algorithmes OSF, RFC 4122, mais aussi certains nommages « propriétaires ».

Ces identifiants uniques sont codés sur 128 bits et sont produits en utilisant des composantes pseudo-aléatoires ainsi que les caractéristiques d'un ordinateur (numéro de disque dur, adresse MAC, etc.).
Un UUID se présente habituellement sous la forme de groupes de caractères hexadécimaux en minuscules séparés par des tirets : 110e8400-e29b-11d4-a716-446655440000

Un UUID est initialement conçu de manière à être unique dans le monde ; cependant, les algorithmes de hachage et 
les générateurs pseudo-aléatoires introduisent un risque non nul que deux ordinateurs produisent un même identifiant. 
La norme ISO définit d'ailleurs des « identificateurs de 128 bits qui sont soit garantis mondialement uniques ou sont mondialement uniques avec une haute probabilité ». 
Quant à la RFC 4122, si elle parle d'identificateur unique, elle précise que les identificateurs issus d'espaces de noms différents sont seulement « différents avec une haute probabilité » (§4.3).

Les UUID sont destinés à l'identification de composants logiciels (plugins), des différents membres dans un système distribué ou d'autres applications nécessitant une identification sans ambiguïté. 
Les UUID peuvent être générés sur les systèmes Unix via la commande uuidgen. Sous debian, le paquet e2fsprogs contient une commande /sbin/blkid 
qui permet d'afficher un UUID correspondant à certains périphériques (paquet util-linux sous RedHat/CentOS).
*/
namespace MOS_Management.Models.TypeDonnées.Simple
{
    [Fhir]
    public class UUID
    {
        public string Uuid { get; set; }
    }
}
