abstract class Activity
{
    protected string _date;

    protected string _activityType;

    protected int _minutes;
    public Activity(string date, int minutes, string activityType)
    {
        _date = date;
        _minutes = minutes;
        _activityType = activityType;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

    public virtual string GetSummary()
    {
        return $"{_date} {_activityType} ({_minutes} min): Distance {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km";
    }
}