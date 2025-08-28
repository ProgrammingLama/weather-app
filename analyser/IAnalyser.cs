namespace WeatherApp.analyser;

public interface IAnalyser
{
    void analyse(Measurement measurement, Region region);
}