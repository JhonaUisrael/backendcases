using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Case
{
    [Key]
    public int CaseId { get; set; } // PK, Identity
    public string CaseNumber { get; set; }
    public string CaseDescription { get; set; }
    public int CaseTypeId { get; set; }
    public DateTime CaseStartDate { get; set; }
    public DateTime CaseEndDate { get; set; }
    public string CasePriority { get; set; }
    public string CaseState { get; set; } = "30"; // Default value
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool Active { get; set; } = true;

    // Relación con CasesType
    public CaseType CasesType { get; set; }

    // Relación muchos a muchos con Person
    public ICollection<PersonCase> PersonCases { get; set; }

public Case()
{
    
}
     public Case( string caseDescription, int caseTypeId, DateTime caseStartDate, DateTime caseEndDate, string casePriority)
    {
        CaseNumber = "caseNumber";
        CaseDescription = caseDescription;
        CaseTypeId = caseTypeId;
        CaseStartDate = caseStartDate;
        CaseEndDate = caseEndDate;
        CasePriority = casePriority;
        CaseState = "creado"; // Valor predeterminado
        CreatedAt = DateTime.Now; // Se asigna automáticamente el valor actual
        Active = true; // Valor predeterminado
    }
}

