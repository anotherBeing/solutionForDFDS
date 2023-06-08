using Application.Data;
using Application.Geocode;
using Domain.Models;
using Domain.Specifications.TruckPlan;

namespace Application.TruckPlan;

public class TruckPlanService : ITruckPlanService
{
    private readonly IRepository<Driver> _driverRepository;
    private readonly IGeoCodeService _geoCodeService;


    public TruckPlanService(
        IRepository<Driver> driverRepository,
        IGeoCodeService geoCodeService)
    {
        _driverRepository = driverRepository;
        _geoCodeService = geoCodeService;
    }

    public async Task<int> GetCurrentDistanceDriven(Domain.Models.TruckPlan truckPlan)
    {
        var startLocation = truckPlan.RoutePlan.Route.StartLocation;
        var currentLocation = truckPlan.Truck.CurrentLocation;

        var startLat = startLocation.Latitude.ToString();
        var startLon = startLocation.Longitude.ToString();

        var currentLat = currentLocation.Latitude.ToString();
        var currentLon = currentLocation.Longitude.ToString();

        var startCoordinate = BuildCoordinate(startLat, startLon);
        var endCoordinate = BuildCoordinate(currentLat, currentLon);

        var result = await _geoCodeService.GetDistance(startCoordinate, endCoordinate);

        //Get the distance from the result
        return default;
    }

    public async Task<int> GetDistanceDrivenForVeteransInGermanyInFebruary()
    {
        var result = await _driverRepository.QueryBySpecification(new GetDriverMilageSpecification(
            driverAge: 50,
            country: "Germany",
            fromDate: new DateTime(2018, 2, 1),
            toDate: IsLeapYear(2018) ? new DateTime(2018, 2, 29) : new DateTime(2018, 02, 28)));

        var totalDistance = result.SelectMany(x =>
            x.CompletedRoutes
                .Select(y =>
                    y.Route.DistanceMetric))
            .ToList()
            .Sum();

        return totalDistance;
    }

    private bool IsLeapYear(int year)
    {
        throw new NotImplementedException();
    }

    private string BuildCoordinate(string currentLat, string currentLon)
    {
        //Combine the latitude and longitude to string used for calling the geoCodeService
        return string.Empty;
    }
}
