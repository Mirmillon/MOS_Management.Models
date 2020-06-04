using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;


namespace MOS_Management.Models.CLassesMos.FromTexte
{
    public class Version :Texte
    {
        public string MetaDonneeId { get; set; }
        public MetaDonnee MetaDonnee { get; set; }

    }
}
