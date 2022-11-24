namespace FHIR_HL7.Models.Types;

public class CodeableConcept
{
    public List<Coding> Coding { get; set; } = new();
    public string Text { get; set; }

    public CodeableConcept(List<Coding> codes)
    {
        Coding.AddRange(codes);
    }

    public CodeableConcept()
    {
    }
}
