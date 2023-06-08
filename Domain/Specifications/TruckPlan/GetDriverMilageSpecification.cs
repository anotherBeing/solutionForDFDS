using Domain.Models;

namespace Domain.Specifications.TruckPlan;

public class GetDriverMilageSpecification : Specification<Driver>
{
    public GetDriverMilageSpecification(int driverAge, string country, DateTime fromDate, DateTime toDate)
    : base(x =>
        x.Age >= driverAge)
    {
        AddInclude(x => x.CompletedRoutes.Where(cr =>
            cr.PlannedStart <= fromDate
            && cr.PlannedEnd >= toDate
            && cr.Route.StartLocation.Country == country
            && cr.Route.EndLocation.Country == country));   
    }
}
