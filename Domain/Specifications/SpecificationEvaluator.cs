using Microsoft.EntityFrameworkCore;

namespace Domain.Specifications;

public static class SpecificationEvaluator
{
    public static IQueryable<TEntity> GetQuery<TEntity>(
        IQueryable<TEntity> inputQueryable,
        ISpecification<TEntity> specification)
        where TEntity : class
    {
        IQueryable<TEntity> queryable = inputQueryable;

        if (specification.Criteria is not null)
        {
            queryable = queryable.Where(specification.Criteria);
        }

        var queryableWithIncludes = specification.IncludeExpressions.Aggregate(
            queryable,
            (current, includeExpression) =>
                current.Include(includeExpression));

        return queryableWithIncludes;
    }
}
