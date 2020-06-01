﻿using EHR_Management.Models.ProjectAttribute;
/*
Les OID (pour object identifier) sont des identifiants universels, représentés sous la forme d'une suite d'entiers. 
Ils sont organisés sous forme hiérarchique avec des nœuds1. Ainsi seul l'organisme 2.999 peut dire quelle est la signification de l'OID 2.999.1. 
Ils ont été définis dans une recommandation de l’International Telecommunication Union. 
L'IETF a proposé de représenter la suite d'entiers constituant les OID séparés par des points.

L'objectif des OID est d'assurer l'interopérabilité entre différents logiciels. 
Les OID sont utilisés dans le monde LDAP mais aussi dans d'autres domaines, comme le protocole SNMP pour identifier des ressources. 
Il est possible d'obtenir un OID, et par conséquent toute une branche, auprès de l'IANA.
*/
namespace MOS_Management.Models.TypeDonnées.Simple
{
    [Fhir]
    public  class OID
    {
        public string Oid { get; set; }
    }
}
