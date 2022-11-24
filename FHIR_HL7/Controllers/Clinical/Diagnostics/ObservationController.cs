using FHIR_HL7.Models.Clinical.Diagnostics;
using FHIR_HL7.Services.Clinical.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace FHIR_HL7.Controllers.Clinical.Diagnostics;

[ApiController]
[Route("clinical/diagnostics/[controller]")]
public class ObservationController : Controller
{
    [HttpGet(Name = "GetAllObservations")]
    public IEnumerable<Observation> GetAll()
    {
        // var link = Url.Link("GetPatientFromCpr", new { cpr = "123456-7890"});
        // var link2 = Url.Link("GetAllPatients", null);
        // Console.WriteLine("sdafdsafas" + link  + " , " + link2);
        return ObservationService.GetAll(Url);
    }

    [HttpGet("{cpr}", Name = "GetObservationsForCpr")]
    public IEnumerable<Observation> GetForCpr(string cpr)
    {
        return new List<Observation>();
    }

}