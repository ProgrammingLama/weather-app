using WeatherApp.analyser;

namespace WeatherApp.manager;

public class MeasureManager : IManager
{
    private List<IAnalyser> _analysers;

    public MeasureManager()
    {
        _analysers = new List<IAnalyser>();
    }

    public void RegisterAnalyser(IAnalyser analyser)
    {
        _analysers.Add(analyser);
    }
    public void UnregisterAnalyser(IAnalyser analyser)
    {
        _analysers.Remove(analyser);
    }
    public void NotifyAllAnalysers(Measurement measurement, Region region)
    {
        foreach (IAnalyser analyser in _analysers)
        {
            analyser.analyse(measurement, region);
        }
    }

}