namespace FHIR_HL7.Models.Types;

public class ContactPoint
{
    public Code? System { get; set; }
    public string? Value { get; set; }
    public Code? Use { get; set; }
    public uint? Rank { get; set; }
    public Period? Period { get; set; }

    public static ContactPoint CreatePhone(string value, string use, uint rank, Period? period)
    {
        return new ContactPoint()
        {
            System = new Code("phone"),
            Value = value,
            Use = new Code(use),
            Rank = rank,
            Period = period
        };
    }

    public ContactPoint()
    {
    }
}