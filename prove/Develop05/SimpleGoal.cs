public class SimpleGoal : Goal
{
    bool condition = false;
    public override void Complete()
    {
        condition = true;
    }
}