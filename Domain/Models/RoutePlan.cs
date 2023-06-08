namespace Domain.Models;

public class RoutePlan
{
    public Route Route { get; set; }
    public DateTime PlannedStart { get; set; }
    public DateTime PlannedEnd { get; set; }
}
