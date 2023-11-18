public class FiniteGoal : Goal
{
    private int _repeats;

    public int GetRepeat()
    {
        return _repeats;
    }
 
    public void SetRepeats(int repeat)
    {
       _repeats = repeat;
    } 
    private int _goaltotalpoints = 0;

    public override void Complete()
    {
        _goaltotalpoints += GetGoalPoints();
        AddRepeatTracker();
        if (_repeatTracker == _repeats)
        {
            SetCompleted();
            _goaltotalpoints += GetGoalPoints() * _repeats;
        }
    }

    private int _repeatTracker;

    public int GetRepeatTracker()
    {
        return _repeatTracker;
    }

    public void AddRepeatTracker()
    {
        _repeatTracker += 1;
    }
}