namespace Application.TruckPlan;

public interface ITruckPlanService
{
    Task<int> GetCurrentDistanceDriven(Domain.Models.TruckPlan truckPlan);

    Task<int> GetDistanceDrivenForVeteransInGermanyInFebruary();
}
