using System.Diagnostics.Metrics;
using WeatherApp.analyser;

namespace WeatherApp.manager;

public interface IManager
{

   public void NotifyAllAnalysers (Measurement measurement);
   public void RegisterAnalyser (IAnalyser analyser);
   public void UnregisterAnalyser (IAnalyser analyser);

}