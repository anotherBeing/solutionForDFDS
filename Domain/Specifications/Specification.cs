using System.Linq.Expressions;

namespace Domain.Specifications;

public class Specification<T> : ISpecification<T> where T : class
{
    public Specification()
    {
    }

    public Specification(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
    }
    
    public Expression<Func<T, bool>> Criteria { get; }
    
    public List<Expression<Func<T, object>>> IncludeExpressions { get; } = new List<Expression<Func<T, object>>>();

    protected void AddInclude(Expression<Func<T, object>> expression)
    {
        IncludeExpressions.Add(expression);
    }
}
