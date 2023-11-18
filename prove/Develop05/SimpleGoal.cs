public class SimpleGoal : Goal
{
    private int _goaltotalpoints = 0;

    public override void Complete()
    {
        _goaltotalpoints += GetGoalPoints();
        SetCompleted();
    }
}