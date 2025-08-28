namespace WeatherApp;

public class Measurement
{
    private float windSpeed;
    private float airTemperature;
    private float precipitation;
    private float waterLevel;
    private Region region;
    private DateTime timestamp;

    public float WaterLevel => this.waterLevel;
    public float WindSpeed => this.windSpeed;
    public float AirTemperature => this.airTemperature;
    public float Precipitation => this.precipitation;
    public DateTime Timestamp => this.timestamp;
    public Region Region
    {
        get => this.region;
        set => this.region = value;
    }
    
    public Measurement(float windSpeed, float airTemperature, float precipitation, float waterLevel, DateTime region)
    {
        this.windSpeed = windSpeed;
        this.airTemperature = airTemperature;
        this.precipitation = precipitation;
        this.waterLevel = waterLevel;
        this.region = Region;
        this.timestamp = DateTime.Now;
    }
}