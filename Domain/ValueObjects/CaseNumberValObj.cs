namespace Domain;

public class CaseNumberValObj
{
    public string Value { get; }

    private CaseNumberValObj(string value)
    {
        Value = value ?? throw new ArgumentNullException(nameof(value));
    }
    public static CaseNumberValObj Generate()
    {
        string generatedValue = $"CASE-{DateTime.UtcNow:yyyyMMddHHmmss}-{Guid.NewGuid().ToString().Substring(0, 8)}";
        return new CaseNumberValObj(generatedValue);
    }

    public override string ToString() => Value;

}
