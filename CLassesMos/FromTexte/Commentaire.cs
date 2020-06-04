using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;


namespace MOS_Management.Models.CLassesMos.FromTexte
{
    public class Commentaire : Texte
    {
        public string MetaDonneeId { get; set; }
        public MetaDonnee MetaDonnee { get; set; }

        public string BoileLettreMMSId { get; set; }
        public BoileLettreMMS BoileLettreMMS { get; set; }
    }
}
