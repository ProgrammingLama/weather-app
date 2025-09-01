namespace WeatherApp;

public class Region
{
    private string _country { get; set; }
    private string _city { get; set; }
    private string _region { get; set; }
    private double _longitude { get; set; }
    private double _latitude { get; set; }


    public string region
    {
        get { return _country; }
        set { _country = value; }        
    }
    public string country
    {
        get { return _country; }
        set { _country = value; }
    }

    public string city
    {
        get { return _city; }
        set { _city = value; }
    }

    public double longitude
    {
        get { return _longitude; }
        set { longitude = value; }
    }
    public double latitude
    {
        get { return _latitude; }
        set { latitude = value; }
    }

    public Region(string country, string region, string city, double longitude, double latitude)
    {

        this._country = country;
        this._city = city;
        this.region = region;
        this.longitude = longitude;
        this.latitude = latitude;


    }

    public string GetRegionInfo()
    {
        return
            $"Following Inforation about Region" +
            $"Country: {_country}" +
            $"Region: {region}" +
            $"City: {_city}" +
            $"Coordinates: {_latitude}, {_longitude}";

    }
}