using MOS_Management.Models.ProfessionnelDossier;
using MOS_Management.Models.TypeDonnées.Complexes;


namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class Ordre : Code
    {
        public string InscriptionOrdreId { get; set; }
        public InscriptionOrdre InscriptionOrdre { get; set; }
    }
}
