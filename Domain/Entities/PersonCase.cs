namespace Domain;

public class PersonCase
{
    public int PersonId { get; set; }
    public Person Person { get; set; }

    public int CaseId { get; set; }
    public Case Case { get; set; }
}
