namespace Application;

public class CaseCreateDto
{
    public string Description { get; set; }
    public int Type { get; set; }
    public int ClientId { get; set; }
    public int PersonId { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Priority { get; set; }

    /* // Constructor
    public CaseCreateDto(string caseDescription, int caseTypeId, DateTime caseStartDate, DateTime caseEndDate, string casePriority)
    {
        Description = caseDescription;
        Type = caseTypeId;
        StartDate = caseStartDate;
        EndDate = caseEndDate;
        Priority = casePriority;
    } */
}
