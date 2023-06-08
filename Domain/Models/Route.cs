namespace Domain.Models;

public class Route
{
    public Location StartLocation { get; set; }
    public Location EndLocation { get; set; }

    public int DistanceMetric
    {
        get
        {
            //EndLocation - StarLocation and convert to the correct unit
            return 42;
        }
    }
}
