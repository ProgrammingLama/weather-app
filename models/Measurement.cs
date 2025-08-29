namespace WeatherApp;

public class Measurement
{
    private float windSpeed;
    private float airTemperature;
    private float precipitation;
    private float waterLevel;
    private DateTime timestamp;
    private Region region;
    

    public float WaterLevel => this.waterLevel;
    public float WindSpeed => this.windSpeed;
    public float AirTemperature => this.airTemperature;
    public float Precipitation => this.precipitation;
    public DateTime Timestamp => this.timestamp;
    public Region Region => this.region;

    public Measurement(float windSpeed, float airTemperature, float precipitation, float waterLevel, DateTime timestamp, Region region)
    {
        this.timestamp = timestamp;
        this.region = region;
        this.windSpeed = windSpeed;
        this.airTemperature = airTemperature;
        this.precipitation = precipitation;
        this.waterLevel = waterLevel;  
    }
}