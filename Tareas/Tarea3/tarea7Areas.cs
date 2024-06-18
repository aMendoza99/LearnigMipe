public abstract class Shape
{
    public abstract double GetArea();
}
//circulo
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
//rectangulo
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public double GetArea(string unit)
    {
        double area = Width * Height;
        switch (unit.ToLower())
        {
            case "cm²":
                return area;
            case "m²":
                return area / 10000; // largo y ancho son cm
            default:
                throw new ArgumentException("Unsupported unit");
        }
    }
}

//clase para mostrar valores de area
class ProgramArea
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Console.WriteLine($"Area of the circle: {circle.GetArea()}");

        Rectangle rectangle = new Rectangle(10, 20);
        Console.WriteLine($"Area of the rectangle (cm²): {rectangle.GetArea()}");
        Console.WriteLine($"Area of the rectangle (m²): {rectangle.GetArea("m²")}");
    }
}