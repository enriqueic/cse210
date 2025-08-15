public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public override string GetDetailsString()
    {
        if(_amountCompleted == _target)
            return $"[X] {_name} ({_description}) — Currently completed: {_amountCompleted}/{_target}";
        else
            return $"[ ] {_name} ({_description}) — Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name}:{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override int GetPoints()
    {
        if(_amountCompleted == _target)
            return _points + _bonus;
        return _points;
    }
}