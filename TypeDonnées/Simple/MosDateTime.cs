using EHR_Management.Models.ProjectAttribute;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

//https://docs.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=netcore-3.1

namespace MOS_Management.Models.TypeDonnées.Simple
{
    [Mos]
    public class MosDateTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MosDateTimeId { get; set; }

        /* 
        An array of all supported standard date and time format specifiers.
        string[] formats = {"d", "D", "f", "F", "g", "G", "m", "o", "r",
                          "s", "t", "T", "u", "U", "Y"};
        */
        [NotMapped]
        string[] formats = {"d", "g", "G", "o", "r", "s", "T", "u", "U", "Y"};
        // Create an array of four cultures.
        [NotMapped]
        CultureInfo[] cultures = {CultureInfo.CreateSpecificCulture("de-DE"),
                                CultureInfo.CreateSpecificCulture("en-US"),
                                CultureInfo.CreateSpecificCulture("es-ES"),
                                CultureInfo.CreateSpecificCulture("fr-FR")};
        [NotMapped]
        public  DateTime DateHeure_ { get; set; }
        [NotMapped]
        public  DateTime Date_ { get; set; }
        [NotMapped]
        public  DateTime Heure_ { get; set; }

        public string DateHeure 
        { 
            get 
            { 
                return DateHeure_.ToString(formats[2], cultures[3]); 
            }
            set { }
        }
        public string Date { get { return DateHeure_.ToString(formats[0], cultures[3]); } set { } }
        public string Heure { get { return DateHeure_.ToString(formats[7], cultures[3]); } set { } }
    }
}
