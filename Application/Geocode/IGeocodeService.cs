using Domain.Models;

namespace Application.Geocode;

public interface IGeoCodeService
{
    Task<Location> ReverseGeocode(double longitude, double latitude);
    Task<int> GetDistance(string origin, string destination);
}
