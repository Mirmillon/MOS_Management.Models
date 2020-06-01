using EHR_Management.Models.ProjectAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
/*
Un URI, de l'anglais Uniform Resource Identifier, soit littéralement identifiant uniforme de ressource, 
est une courte chaîne de caractères identifiant une ressource sur un réseau (par exemple une ressource Web) physique ou abstraite, 
et dont la syntaxe respecte une norme d'Internet mise en place pour le World Wide Web (voir RFC 3986). 
La norme était précédemment connue sous le terme UDI1.
*/
namespace MOS_Management.Models.TypeDonnées.Simple
{
    [Mos]
    [Fhir]
    public class MosUri 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MosUriId { get; set; }
        [Display(Name = "Uri")]
        [MaxLength(250)]
        public string Label { get; set; }
    }
}
