using FHIR_HL7.Models.Clinical.Diagnostics;
using FHIR_HL7.Models.Types;
using Microsoft.AspNetCore.Mvc;

namespace FHIR_HL7.Services.Clinical.Diagnostics;

public class ObservationService
{
    public static IEnumerable<Observation> GetAll(IUrlHelper urlHelper)
    {
        // return Observations.Select(obs =>
        // {
        //     obs.Subject.Type = new Uri(urlHelper.Link("GetPatientFromCpr", new { cpr = obs.Subject.Identifier.Value }));
        //     return obs;
        // });
        return Observations;
    }

    private static List<Observation> Observations = new List<Observation>()
    {
        Observation.Create()
    };
}