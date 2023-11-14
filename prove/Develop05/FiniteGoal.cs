public class FiniteGoal : Goal
{
    private int _repeats;

    public int GetRepeat()
    {
        return _repeats;
    }
   public void SetRepeat(int repeat)
   {
      _repeats = repeat;
   } 

    private int _goaltotalpoints = 0;
    public override void Complete()
    {
        _goaltotalpoints += GetGoalPoints();
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

    public 

    public override void Complete()
    {
        if(_repeatTracker == _repeats)
        {
            
        }
    }

}