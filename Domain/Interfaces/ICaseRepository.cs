namespace Domain;

public interface ICaseRepository
{
    //Task<Case> GetByIdAsync(string id);
    Task<IEnumerable<Case>> GetAllAsync();
    Task<IEnumerable<Case>> GetAllByPriorityAsync(string priority);

    Task<bool> CreateSync(Case entity);


}
