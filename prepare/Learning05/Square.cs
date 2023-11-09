public class Square : Shape
{
    private float _side;
    public void setSide(float side)
    {
        _side = side;
    }
    public float getSide()
    {
        return _side;
    }
    public override double GetArea()
    {
        double area = Math.Pow(_side, 2);
        return area;
    }
}