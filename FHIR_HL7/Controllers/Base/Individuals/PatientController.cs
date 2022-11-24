using FHIR_HL7.Models.Base.Individuals;
using FHIR_HL7.Services;
using Microsoft.AspNetCore.Mvc;

namespace FHIR_HL7.Controllers.Base.Individuals;

[ApiController]
[Route("base/individuals/[controller]")]
public class PatientController : ControllerBase
{
    [HttpGet(Name = "GetAllPatients")]
    [Produces("application/hal+json")]
    public IEnumerable<Patient> GetAll()
    {
        
        return PatientService.GetAll().Select(patient =>
        {
            patient.Links = new List<Link>()
            {
                new Link()
                {
                    Rel = "self",
                    HRef = Url.Link("GetPatientFromCpr", new { cpr = patient.Identifier.First().Value }),
                    Method = "Get"
                },
                new Link()
                {
                    Rel = "observations",
                    HRef = Url.Link("GetObservationsForCpr", new { cpr = patient.Identifier.First().Value }),
                    Method = "Put"
                }

            };
            return patient;
        });
        /*
         [Produces("application/hal+json")]

         return PatientService.GetAll().Select(patient =>
        {
            Console.WriteLine(patient.Identifier.First().Value);
            patient.Links = new List<Link>()
            {
                new()
                {
                    Rel = "self",
                    HRef = Url.Link("GetPatientFromCpr", new { cpr = patient.Identifier.First().Value })
                },
            };
            return patient;
        });*/
    }

    [HttpGet("{cpr}", Name = "GetPatientFromCpr")]
    public Patient Get(string cpr)
    {
        return GetParient(cpr);
    }

    [HttpPost]
    public IActionResult Create(Patient patient)
    {
        PatientService.Add(patient);
        return CreatedAtAction(nameof(Create), new { id = patient.Identifier.First().Value }, patient);
    }

    [HttpDelete("{cpr}")]
    public IActionResult Delete(string cpr)
    {
        var patient = GetParient(cpr);

        if (patient is null)
        {
            return NotFound();
        }

        if (PatientService.Delete(patient))
        {
            return NoContent();
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "Not deleted");
    }
    

    private static Patient? GetParient(string cpr)
    {
        return PatientService.GetAll().Find(patient =>
            patient.Identifier.Exists(identifier => 
                identifier.Use.Value == "cpr" &&
                identifier.Value == cpr));
    }
}