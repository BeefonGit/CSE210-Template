using System.Formats.Asn1;

public class Rectangle : Shape
{
    private float _length;
    private float _width;
    public void setLength(float length)
    {
        _length = length;
    }
    public float getLength()
    {
        return _length;
    }
    public void setWidth(float width)
    {
        _width = width;
    }
    public float getWidth()
    {
        return _width;
    }
    public override double GetArea()
    {
        float area = _length*_width;
        return area;
    }
}