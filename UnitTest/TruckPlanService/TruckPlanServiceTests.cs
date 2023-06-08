using Application.Geocode;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Moq;

namespace UnitTest.TruckPlanService;
using Application.TruckPlan;

public class TruckPlanServiceTests
{
    private Mock<ITruckPlanService> _truckPlanServiceMock;
    private Mock<IGeoCodeService> _geocodeServiceMock;

    public TruckPlanServiceTests()
    {
        _truckPlanServiceMock = new();
        _geocodeServiceMock = new();
    }

    [Fact]
    public void GetDistanceDrivenForVeteransInGermanyInFebruary_ShouldReturnCorrectDistance()
    {
        //arrange
        SetupMocks()

        var sut = new TruckPlanService()
    }

    private void SetupMocks()
    {
        _truckPlanServiceMock
    }
}
