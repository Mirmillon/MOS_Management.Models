using EHR_Management.Models.ProjectAttribute;
using MOS_Management.Models.CLassesMos.FromCode;
using MOS_Management.Models.TypeDonnées.Complexes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MOS_Management.Models.ClassesCommunes
{
    [Mos]
    public  class AutoriteEnregistrement
    {
        [Mos]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AutoriteEnregistrementId { get; set; }
        [Mos]
        public Autorite Autorite { get; set; } //C'est un codeId de Code

        [Mos]
        public TypeAutorite TypeAutorite { get; set; }
        [Mos]
        public Identifiant Identifiant { get; set; }

        [NotMapped]
        public string TypeName { get { return this.GetType().ToString(); } set { } }

        //FK
        public string MetaDonneeId { get; set; }
        public MetaDonnee MetaDonnee { get; set; }
    }
}
