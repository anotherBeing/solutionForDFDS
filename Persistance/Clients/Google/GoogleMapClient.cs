using Application.Geocode.Client;

namespace Infrastructure.Clients.Google;

public class GoogleMapClient : IGoogleMapClient
{
    //Configure the client with baseAddress, headers, API key etc from config
    public Task<HttpResponseMessage> SendAsync(Uri uri)
    {
        throw new NotImplementedException();
    }
}
