public abstract class Goal
{
    private string _goalname;

    public void SetGoalName(string GoalName)
    {
        _goalname = GoalName;
    }
    public string GetGoalName()
    {
        return _goalname;
    }
    private string _goaldescription;

    public void SetGoalDescription(string SetGoalDescription)
    {
        _goalname = SetGoalDescription;
    }
    public string GetGoalDescription()
    {
        return _goaldescription;
    }

    private int _goalpoints;
    public void SetGoalPoints(int GoalPoints)
    {
        _goalpoints = GoalPoints;
    }
    public int GetGoalPoints()
    {
        return _goalpoints;
    }
    private int _goaltotalpoints = 0;

    public int GetTotalPoints()
    {
        return _goaltotalpoints;
    }

    private bool _completed = false;
    public void SetCompleted()
    {
        _completed = true;
    } 
    public bool GetCompleted()
    {
        return _completed;
    }
    
    public abstract void Complete();
}
