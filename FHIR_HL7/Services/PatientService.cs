using FHIR_HL7.Models;
using FHIR_HL7.Models.Base.Individuals;
using FHIR_HL7.Models.Types;

namespace FHIR_HL7.Services;

public class PatientService
{
    private static readonly List<Patient> Patients = new List<Patient>()
    {
        new Patient(new List<Identifier>()
            {
                Identifier.Create("cpr", "usual", "abcd", "234567-7890")
            },
            new List<HumanName>()
            {
                new HumanName(new List<string>() { "Henrik"}, new List<string>(), new List<string>())
                {
                    Family = "Kirk"
                    
                }
            }, new List<ContactPoint>()
            {
                ContactPoint.CreatePhone("123141512", "home", 1, new Period(DateTime.Now, DateTime.MaxValue))
            }) 
        {
            Active = true,
            Gender = new Code("Male"),
            BirthDay = DateTime.Parse("1982-06-11T00:00:00.000000Z")
        },
        new Patient(new List<Identifier>()
            {
                Identifier.Create("cpr", "usual", "abcd", "123456-7890")
            },
            new List<HumanName>()
            {
                new HumanName(new List<string>() { "Ehab"}, new List<string>(), new List<string>())
                {
                    Family = "Basha"
                    
                }
            }, new List<ContactPoint>()
            {
                ContactPoint.CreatePhone("123141512", "home", 1, new Period(DateTime.Now, DateTime.MaxValue))
            }) 
        {
            Active = true,
            Gender = new Code("Male"),
            BirthDay = DateTime.Parse("2000-11-11T00:00:00.000000Z")
        },
    };

    public static List<Patient> GetAll()
    {
        return Patients;
    }

    public static void Add(Patient patient)
    {
        Patients.Add(patient);
    }

    public static bool Delete(Patient patient)
    {
        return Patients.Remove(patient);
    }
}
