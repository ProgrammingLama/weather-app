namespace WeatherApp;

public class Measurement
{
    private float windSpeed;
    private float airTemperature;
    private float precipitation;

    private float pressure;
    private DateTime timestamp;
    private Region region;
    
    public float WindSpeed => this.windSpeed;
    public float AirTemperature => this.airTemperature;
    public float Precipitation => this.precipitation;

    public float Pressure => this.pressure;
    public DateTime Timestamp => this.timestamp;
    public Region Region => this.region;


    public Measurement(float windSpeed, float airTemperature, float precipitation, float pressure, DateTime timestamp, Region region)
    {
        this.timestamp = timestamp;
        this.region = region;
        this.pressure = pressure;
        this.windSpeed = windSpeed;
        this.airTemperature = airTemperature;
        this.precipitation = precipitation;

    }
}