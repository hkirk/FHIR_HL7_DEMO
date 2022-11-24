namespace FHIR_HL7.Models.Types;

public class Code
{
    public string Value { get; set; }
    
    public Code(string value)
    {
        Value = value;
    }

    public Code()
    {
    }
}