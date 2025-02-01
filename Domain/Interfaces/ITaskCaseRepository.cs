namespace Domain;

public interface ITaskCaseRepository
{
    Task<bool> CreateSync(TaskCase entity);
    Task<IEnumerable<TaskCase>> GetAllAsync();
    Task<TaskCase> GetByCaseAsync(int caseId); 
}
