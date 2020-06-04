using MOS_Management.Models.ClassesCommunes;
using MOS_Management.Models.TypeDonnées.Complexes;


namespace MOS_Management.Models.CLassesMos.FromCode
{
    public class TypeMessagerie:Code
    {
        public string TeleCommunicationId { get; set; }
        public TeleCommunication TeleCommunication { get; set; }
    }
}
