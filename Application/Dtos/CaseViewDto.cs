namespace Application;

public class CaseViewDto
{
    public string CaseNumber { get; set; }
    public string Description { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Priority { get; set; }
    public string State { get; set; } 
 
    // Relación con CasesType
    public CaseTypeViewDto CaseType { get; set; }

    public PersonViewDto Person { get; set; }

    public ClientViewDto Client { get; set; }

}
