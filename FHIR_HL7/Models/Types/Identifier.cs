namespace FHIR_HL7.Models.Types;

public class Identifier
{
    public Code? Use { get; set; }
    public CodeableConcept? Type { get; set; }
    public Uri? System { get; set; }
    public string? Value { get; set; }
    public Period? Period { get; set; }

    public static Identifier Create(string use, string code, string codeableConcpetText, string value)
    {
        return new Identifier()
        {
            Use = new Code(use),
            Type = new CodeableConcept(new List<Coding>()
            {
                new Coding()
                {
                    System = new Uri("http://fhir/hl7/coding"),
                    Code = new Code(code),
                    Display = "Identifier"
                }
            })
            {
                Text = codeableConcpetText
            },
            Value = value
        };
    }
}