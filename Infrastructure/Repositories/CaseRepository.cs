using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class CaseRepository : ICaseRepository
{
    private readonly AppDbContext _context;

    public CaseRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<bool> CreateSync(Case entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Case>> GetAllAsync()
    {
        return await _context.Case
        .Include(t => t.CaseType)
        .Include(p => p.Person)
        .Include(c => c.Client)
        .ToListAsync();
    }

    public async Task<IEnumerable<Case>> GetAllByPriorityAsync(string priority)
    {
        return await _context.Case.Where(c => c.CasePriority == priority)
         .Include(t => t.CaseType)
        .Include(p => p.Person)
        .Include(c => c.Client)
        .ToListAsync();
    }
}
