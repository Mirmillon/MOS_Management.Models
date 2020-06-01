using EHR_Management.Models.ProjectAttribute;

/*
A URI that refers to a resource by its canonical URL (resources with a url property). 
The canonical type differs from a uri in that it has special meaning in this specification, 
and in that it may have a version appended, separated by a vertical bar (|). 
Note that the type canonical is not used for the actual canonical URLs that are the target of these references, 
but for the URIs that refer to them, and may have the version suffix in them. 
Like other URIs, elements of type canonical may also have #fragment references
*/
namespace MOS_Management.Models.TypeDonnées.Simple
{
    [Fhir]
    public class Canonical: MosUri
    {
        public string  canonical { get; set; }
    }
}
