public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public override string GetDetailsString()
    {
        if (_isComplete)
            return $"[X] {_name}({_description}) - [{_points} points]";
        else
            return base.GetDetailsString();
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name}:{_description}:{_points}:{_isComplete}";
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
}