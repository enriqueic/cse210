class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int minutes, double distance)
        : base(date, minutes, "Running")
    {
        _distance = distance;
    }
    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        return _distance / _minutes * 60;
    }
    public override double Pace()
    {
        return _minutes / _distance;
    }
}