namespace FHIR_HL7.Models.Types;

public class Period
{
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }

    public Period(DateTime? start, DateTime? end)
    {
        Start = start;
        End = end;
    }
}