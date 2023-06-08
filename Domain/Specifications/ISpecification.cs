using System.Linq.Expressions;

namespace Domain.Specifications;

public interface ISpecification<T> where T : class
{
    Expression<Func<T, bool>> Criteria { get; }
    List<Expression<Func<T, object>>> IncludeExpressions { get; }
}
