namespace Domain;

public interface ICaseRepository
{
    //Task<Case> GetByIdAsync(string id);
    Task<IEnumerable<Case>> GetAllAsync();

    Task<bool> CreateSync(Case entity);


}
