namespace FHIR_HL7.Models.Types;

public class HumanName
{
    public Code? Use { get; set; }
    public string? Text { get; set; }
    public string? Family { get; set; }
    public List<string> Given { get; set; } = new();
    public List<string> Prefix { get; set; } = new ();
    public List<string> Suffix { get; set; } = new();
    public Period? Period { get; set; }

    public HumanName()
    {
    }

    public HumanName(List<String> given, List<string> prefix, List<string> suffix)
    {
        Given.AddRange(given);
        Prefix.AddRange(prefix);
        Suffix.AddRange(prefix);
    }
}