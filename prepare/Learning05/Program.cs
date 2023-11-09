using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list_shape = new();
        Circle circle = new();
        circle.setColor("blue");
        circle.setRadius(3);
        Rectangle rectangle = new();
        rectangle.setColor("red");
        rectangle.setLength(4);
        rectangle.setWidth(3);
        Square square = new();
        square.setColor("orange");
        square.setSide(2);
        list_shape.Add(circle);
        list_shape.Add(rectangle);
        list_shape.Add(square);

        foreach(Shape shape in list_shape)
        {
            Console.WriteLine(shape.getColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}