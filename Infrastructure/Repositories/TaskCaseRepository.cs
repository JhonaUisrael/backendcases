using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TaskCaseRepository : ITaskCaseRepository
{
    private readonly AppDbContext _context;

    public TaskCaseRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<bool> CreateSync(TaskCase entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<TaskCase>> GetAllAsync()
    {
        return await _context.TaskCase
        .Include(c => c.Case)
       .ToListAsync();
    }



    public async Task<TaskCase> GetByCaseAsync(int caseId)
    {
        var found = await _context.TaskCase.AnyAsync(c => c.CaseId == caseId);
        if (!found)
        {
            throw new KeyNotFoundException("caso no encontrado");

        }
          var taskCase = await _context.TaskCase.Include(c=>c.Case)
          .FirstOrDefaultAsync(c => c.CaseId == caseId);
            return taskCase;

    }
}
