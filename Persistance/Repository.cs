using Application.Data;
using Domain.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>()
            .Remove(entity);
    }

    public async Task<IEnumerable<TEntity>> QueryBySpecification(ISpecification<TEntity> specification)
    {
        return await SpecificationEvaluator.GetQuery(
                _context.Set<TEntity>(),
                specification)
            .ToListAsync();
    }

    public async Task<TEntity?> GetById(int id)
    {
        return await _context.Set<TEntity>()
            .FindAsync(id);
    }

    public void Insert(TEntity entity)
    {
        _context.Set<TEntity>()
            .Add(entity);
    }

    public Task SaveChangesAsync()
    {
        return _context
            .SaveChangesAsync();
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>()
            .Update(entity);
    }
}
