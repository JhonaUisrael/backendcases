namespace Domain;

public class CaseType
{
    public int CaseTypeId { get; set; } // PK, Identity
    public string CaseName { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public bool Active { get; set; } = true;

    // Relación inversa con Cases
    public ICollection<Case> Cases { get; set; }
}
