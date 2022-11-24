using FHIR_HL7.Models.Types;

namespace FHIR_HL7.Models.Clinical.Diagnostics;

public class Observation
{
    public List<Identifier> Identifier { get; set; } = new();
    public List<Reference> BasedOn { get; set; } = new();
    public List<Reference> PartOf { get; set; } = new ();
    public Code Status { get; set; }
    public List<CodeableConcept> Category { get; set; } = new();
    public CodeableConcept Code { get; set; }
    public Reference Subject { get; set; }
    public List<Reference> Focus { get; set; } = new();
    public Reference Encounter { get; set; }

    public static Observation Create()
    {
        return new Observation()
        {
            Identifier = new List<Identifier>()
            {
                new Identifier()
                    {
                    Use = new Code("official"),
                    Type = new CodeableConcept()
                    {
                        Text = "Result of something is..."
                    },
                    System = new Uri("http://hl7.fhir/obs"),
                    Value = "obs:12314512"
                }
            },
            BasedOn = new List<Reference>()
            {
                Reference.CreateCarePlan("cp:12341"),
                Reference.CreateCarePlan("cp:14123")
            },
            PartOf = new List<Reference>()
            {
                Reference.CreateProcedure("pr:asdf32")
            },
            Status = new Code("registered"),
            Category = new List<CodeableConcept>()
            {
                new CodeableConcept()
                {
                    Coding = new List<Coding>()
                    {
                        new Coding()
                        {
                            System = new Uri("https://hl7.org/fhir/ValueSet/observation-category")
                        }
                    },
                    Text = "Preferred"
                }
            },
            Code = new CodeableConcept()
            {
                Coding = new List<Coding>()
                {
                    new()
                    {
                        System = new Uri("https://hl7.org/fhir/ValueSet/observation-codes"),
                        Code = new Code("100016-5")
                    }
                },
                Text = "No injury related to a laser source"
            },
            Subject = Reference.CreatePatient("123456-7890"),
        };
    }
}