using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Specifications;

namespace Application.Data;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity?> GetById(int id);

    void Insert(TEntity entity);

    void Update(TEntity entity);

    void Delete(TEntity entity);

    public Task<IEnumerable<TEntity>> QueryBySpecification(ISpecification<TEntity> specification);

    Task SaveChangesAsync();
}
