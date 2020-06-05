using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
/*
Diplôme européen d'études spécialisées, d'un pays de l'espace économique européen (EEE),
ouvrant l'accès à une spécialité, pour un professionnel s'inscrivant à l'ordre à compter de la date
d'entrée du pays dans l'EEE (Directive européenne 2005-36 modifiée). L'annexe 5 de cette
directive donne la liste des reconnaissances mutuelles de diplômes de spécialité au sein de l'EEE.
*/

namespace eSanteRazor.Models.MOS.Gens.Professionnelle._NiveauFormation._Diplomes
{
    public class DiplomeEES :Diplome
    {
        [MaxLength(6)]
        [Display(Name = "Diplome Européen E.S")]
        public string DESCGroupe1DiplomeId { get; set; }

        public DiplomeEES():base()
        {
            TypeDiplomeId = "DEES";
        }
    }
}
