using Application.Geocode.Client;
using Domain.Models;

namespace Application.Geocode;

public class GeocodeService : IGeoCodeService
{
    private readonly IGoogleMapClient _googleMapClient;
    private string _reverseGeocodeTemplate = $"/geocode/json?latlng={0},{1}&key=YOUR_API_KEY";
    private string _distanceGeocodeTemplate = $"/distancematrix/json?origins={0}&destinations={2}&units={3}";

    public GeocodeService(IGoogleMapClient googleMapClient)
    {
        _googleMapClient = googleMapClient;
    }

    public async Task<Location> ReverseGeocode(double longitude, double latitude)
    {
        var endpoint = string.Format(_reverseGeocodeTemplate, latitude, longitude);

        var result = await _googleMapClient.SendAsync(new Uri(endpoint));

        //Convert the result into a domain class, Location, where country information (and more) is contained
        //and then return that Location

        return new Location();
    }

    public async Task<int> GetDistance(string origin, string destination)
    {
        //Build url from the _distanceGeocodeTemplate, inserting coordinates, preferred distance unit etc
        //e.g. var endpoint = string.Format(_distanceGeocodeTemplate, origin, destination, metric);
        var endpoint = string.Empty;

        var result = await _googleMapClient.SendAsync(new Uri(endpoint));

        //convert the result 

        return default;
    }

   
}
