namespace FHIR_HL7.Models.Types;

public class Coding
{
    public Uri System { get; set; }
    public string Version { get; set; }
    public Code Code { get; set; }
    public string Display { get; set; }
    public bool UserSelected { get; set; }
}