using EHR_Management.Models.ProjectAttribute;
using System;
using System.Globalization;

//https://docs.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=netcore-3.1

namespace MOS_Management.Models.TypeDonnées.Simple
{
    [Mos]
    public class MosDateTime
    {
        /* 
        An array of all supported standard date and time format specifiers.
        string[] formats = {"d", "D", "f", "F", "g", "G", "m", "o", "r",
                          "s", "t", "T", "u", "U", "Y"};
        */
        string[] formats = {"d", "g", "G", "o", "r", "s", "T", "u", "U", "Y"};
        // Create an array of four cultures.
        CultureInfo[] cultures = {CultureInfo.CreateSpecificCulture("de-DE"),
                                CultureInfo.CreateSpecificCulture("en-US"),
                                CultureInfo.CreateSpecificCulture("es-ES"),
                                CultureInfo.CreateSpecificCulture("fr-FR")};

        public  DateTime _DateHeure { get; set; }
        public  DateTime _Date { get; set; }
        public  DateTime _Heure { get; set; }

        public string DateHeure 
        { 
            get 
            { 
                return _DateHeure.ToString(formats[2], cultures[3]); 
            }
            set { }
        }
        public string Date { get { return _DateHeure.ToString(formats[0], cultures[3]); } set { } }
        public string Heure { get { return _DateHeure.ToString(formats[7], cultures[3]); } set { } }
    }
}
