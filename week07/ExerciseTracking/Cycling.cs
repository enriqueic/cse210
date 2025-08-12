class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int minutes, double speed)
        :base(date, minutes, "Cycling")
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return _speed / 60 * _minutes;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        return 60 / _speed;
    }
}