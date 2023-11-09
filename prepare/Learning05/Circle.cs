public class Circle : Shape
{
    private float _radius;
    public void setRadius(float radius)
    {
        _radius = radius;
    }
    public float getRadius()
    {
        return _radius;
    }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}