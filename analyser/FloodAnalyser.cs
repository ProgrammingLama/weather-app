namespace WeatherApp.analyser;

public class FloodAnalyser : IAnalyser
{
    public void analyse(Measurement measurement)
    {
        float floodRiskLevel = measurement.Region.floodRiskLevel;
        float waterLevel = measurement.WaterLevel;
        if (waterLevel > floodRiskLevel)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ { Prio.High }] Water level in {measurement.Region.city} is ABOVE flood risk level by {waterLevel - floodRiskLevel:0.00}!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Flood Safe] Water level in {measurement.Region.city} is BELOW flood risk level by {floodRiskLevel - waterLevel:0.00}.");
        }
        Console.ResetColor();
    }

}