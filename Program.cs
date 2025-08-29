using WeatherApp.analyser;
using WeatherApp.manager;

namespace WeatherApp;

public class Program
{
    public static void Main(string[] args)
    {
        Region florida = new Region("America", "US", "Florida", 50, 20, 100 , 25);
        Region florida2 = new Region("America", "US", "Florida", 50, 20, 100 , 25);
        Region newYork = new Region("America", "US", "New York", 10, 10, 10 , 40);
        Measurement measurementFlorida = new Measurement(15, 20, 25, 30, DateTime.Now, florida);
        Measurement measurementNewYork = new Measurement(40, 120, 20, 48, DateTime.Now, newYork);
        IAnalyser stormAnalyser = new StormAnalyser();
        IAnalyser floodAnalyser = new FloodAnalyser();
        MeasureManager measureManager = new MeasureManager();
        measureManager.RegisterAnalyser(stormAnalyser);
        measureManager.RegisterAnalyser(floodAnalyser);
        measureManager.NotifyAllAnalysers(measurementNewYork);
        measureManager.NotifyAllAnalysers(measurementFlorida);

        Console.WriteLine(florida.Equals(florida)); // true
        Console.WriteLine(florida.Equals(newYork)); // false
        Console.WriteLine(florida.Equals(florida2)); // 
    }
}