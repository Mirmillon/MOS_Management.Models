using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;


namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class RoleContact : Code
    {
        public string ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
