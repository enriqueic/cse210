class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int minutes, int laps)
        :base(date, minutes, "Swimming")
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 1000.0;
    }
    public override double Speed()
    {
        return Math.Round(Distance() / _minutes * 60, 2);
    }
    public override double Pace()
    {
        return _minutes / Distance();
    }
}