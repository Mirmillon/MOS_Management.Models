using EHR_Management.Models.ProjectAttribute;
using System;
using System.Collections.Generic;
using System.Text;
/*
Une URL (sigle de l’anglais : Uniform Resource Locator, littéralement « localisateur uniforme de ressource »), 
couramment appelée adresse web, est une chaîne de caractères uniforme qui permet d'identifier une ressource du World Wide Web par son emplacement 
et de préciser le protocole internet pour la récupérer (par exemple http ou https). 
Elle peut localiser divers formats de données : document HTML, image, son....

Les URL constituent un sous-ensemble des identifiants uniformes de ressource (Uniform Resource Identifier, URI), 
identifiants uniques d'accès à une ressource. 
La syntaxe d'une URL est décrite dans la RFC 39863.
*/
namespace MOS_Management.Models.TypeDonnées.Simple
{
    [Fhir]
    public class URL : MosUri
    {

        // Common URL protocols are http{s}:, ftp:, mailto: and mllp:, though many others are defined
        public string Url { get; set; }
    }
}
