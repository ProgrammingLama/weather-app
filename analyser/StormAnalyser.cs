namespace WeatherApp.analyser;

public class StormAnalyser : IAnalyser
{
    public void analyse(Measurement measurement)
    {
        float windRiskSpeed = measurement.Region.windRiskSpeed;
        float windSpeed = measurement.WindSpeed;
        if (windSpeed > windRiskSpeed)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ { Prio.Medium }]  Wind speed in {measurement.Region.city} is ABOVE wind risk speed by {windSpeed - windRiskSpeed:0.00}!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Storm Safe] Wind speed in {measurement.Region.city} is BELOW wind risk speed by {windRiskSpeed - windSpeed:0.00}.");
        }
        Console.ResetColor();
    }
}