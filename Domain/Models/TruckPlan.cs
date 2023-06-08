using Domain.Models;

namespace Domain.Models;

public class TruckPlan
{
    public Driver Driver { get; set; }
    public RoutePlan RoutePlan { get; set; }
    public Truck Truck { get; set; }
}
