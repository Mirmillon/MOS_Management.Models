using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.TypeDonnées.Complexes.Complexes_;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.TypeDonnées.Complexes
{
    [Mos]
    public  class Indicateur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IndicateurId { get; set; }
        [NotMapped]
        internal string TypeName { get { return "Indicateur"; } }
        [NotMapped]
        internal Object Valeur { get; set; }
        [MaxLength(30)]
        public  string  TypeValeur {
            get
            {
                if(Valeur != null)
                {
                    return GetTypeName(Valeur);
                }
                else
                {
                    return null;
                }
                
            }
            set {; }
        }


        private  string GetTypeName(object o)
        {
            if(typeof(String) == o.GetType())
            {
                return "String";
            }
            else if (typeof(Boolean) == o.GetType())
            {
                return "Boolean";
            }
            else if ( typeof(Int16)  == o.GetType())
            {
                return "Integer 16";
            }
            else if (typeof(Int32)  == o.GetType())
            {
                return "Integer 32";
            }
            else if (typeof(Int64) == o.GetType())
            {
                return "Integer 64";
            }
            else
            {
                return null;
            }

        }


    }
}
