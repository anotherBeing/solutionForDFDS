namespace Domain.Models;

public class Driver
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public IEnumerable<RoutePlan> CompletedRoutes { get; set; }
    public IEnumerable<RoutePlan> PlannedRoutes { get; set; }
    public int Age => GetAge();

    private int GetAge()
    {
        var today = DateTime.Today;

        var age = today.Year - BirthDate.Year;

        // Leap year handling
        if (BirthDate.Date > today.AddYears(-age))
            age--;

        return age;
    }
}
