namespace Application.Geocode.Client;

public interface IGoogleMapClient
{
    Task<HttpResponseMessage> SendAsync(Uri uri);
}

