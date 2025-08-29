namespace WeatherApp;

public class Region
{
    private string _continent { get; set; }
    private string _country {get; set;}
    private string _city { get; set; }

    private float _floodRiskLevel;
    private float _temperatureRiskLevel;
    private float _windRiskSpeed;
    private float _precipitationRiskLevel;
    

    public float floodRiskLevel
    {
        get { return _floodRiskLevel; }
        set { _floodRiskLevel = value; }
    }

    public float temperatureRiskLevel
    {
        get { return _temperatureRiskLevel; }
        set => _temperatureRiskLevel = value;
    }

    public float windRiskSpeed
    {
        get { return _windRiskSpeed; }
        set => _windRiskSpeed = value;
    }

    public float precipitationRiskLevel
    {
        get { return _precipitationRiskLevel; }
        set => _precipitationRiskLevel = value;
    }
    public string continent
    {
        get { return _continent; }
        set { _continent = value; }
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


    public Region(string continent, string country, string city, float floodRiskLevel, float temperatureRiskLevel, float windRiskSpeed, float precipitationRiskLevel)
    {
        this._continent = continent;
        this._country = country;
        this._city = city;
        this._floodRiskLevel = floodRiskLevel;
        this._temperatureRiskLevel = temperatureRiskLevel;
        this._windRiskSpeed = windRiskSpeed;
        this._precipitationRiskLevel = precipitationRiskLevel;
    }
    
    public string GetRegionInfo()
    {
        return
            $"Following Inforation about Region" +
            $"Continent: {_continent}" +
            $"Country: {_country}" +
            $"City: {_city}";
    }
    
    public string GetRiskLevels()
    {
        return
            $"Following Inforation about Risk Levels" +
            $"Flood Risk Level: {_floodRiskLevel}" +
            $"Temperature Risk Level: {_temperatureRiskLevel}" +
            $"Wind Risk Level: {_windRiskSpeed}" +
            $"Precipitation Risk Level: {_precipitationRiskLevel}";
    }

    public override bool Equals(object? obj)
    {
        return this._city == (obj as Region).city;
    }
}