namespace WeatherApp;

public class Warning
{
    private Prio Prio;

    private WarningType warningType;


    public Warning(Prio prio, WarningType warningType)
    {
        this.Prio = prio;
        this.warningType = warningType;
    }

    public void isValid()
    {

    }
}