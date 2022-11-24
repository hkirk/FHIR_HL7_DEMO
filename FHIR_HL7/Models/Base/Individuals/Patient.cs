using FHIR_HL7.Models.Types;

namespace FHIR_HL7.Models.Base.Individuals;


public class Link
{
    public string? Rel { get; set; }
    public string? HRef { get; set; }
    public string? Method { get; set; }
}

public abstract class LinkedResource
{
    public List<Link> Links { get; set; }
    public string HRef { get; set; }
}


public class Patient : LinkedResource
{
    public List<Identifier> Identifier { get; set;  } = new();
    public bool? Active { get; set; }
    public List<HumanName> Name { get; set;  } = new();
    public List<ContactPoint> Telecom { get; set;  } = new ();
    public Code? Gender { get; set; }
    public DateTime? BirthDay { get; set; }

    public Patient()
    {
    }
    public Patient(List<Identifier> identifiers, List<HumanName> names, List<ContactPoint> contactPoints)
    {
        Identifier.AddRange(identifiers);
        Name.AddRange(names);
        Telecom.AddRange(contactPoints);
    }
}