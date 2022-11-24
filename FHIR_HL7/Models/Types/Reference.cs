using FHIR_HL7.Controllers.Base.Individuals;
using Microsoft.AspNetCore.Mvc.Routing;

namespace FHIR_HL7.Models.Types;

public class Reference
{
    public string? LiteralReference { get; set; }
    public Uri? Type { get; set; }
    public Identifier? Identifier { get; set; }
    public string? Display { get; set; }

    public static Reference CreateCarePlan(string id)
    {
        return Create("CarePlan", "http://localhost:7288/clinical/careprovision/careplan/", id);
    }

    public static Reference CreateProcedure(string id)
    {
        return Create("Procedure", "http://localhost:7288/clinical/summary/procedure/", id);

    }
    
    public static Reference CreatePatient(string id)
    {
        
        // return Create("Patient", 
        return Create("Patient", "https://localhost:7288/base/individuals/patient/{id}", id);
    }
    
    private static Reference Create(string type, string? uri, string id)
    {
        return new Reference()
        {
            LiteralReference = type,
            Type = (uri == null ? new Uri(uri) : null),
            Identifier = new Identifier()
            {
                Use = new Code(type),
                Value = id
            },
            
        };
    }
}