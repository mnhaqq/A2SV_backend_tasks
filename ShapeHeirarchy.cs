// Tests are in Program.cs

class Shape
{
    protected string Name {get; set;}
    public Shape(string name)
    {
        this.Name = name;
    }

    public virtual double CalculateArea()
    {
        return 0.0;
    }

    public static void PrintShapeArea(Shape shape)
    {
        Console.WriteLine($"Area of {shape.Name} is {shape.CalculateArea().ToString("0.00")} metres square");
    }
}

class Circle : Shape
{
    double Radius {get; set;}

    public Circle(string name, double radius) : base(name)
    {
        this.Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }
}

class Rectangle : Shape
{
    double Width {get; set;}
    double Height{get; set;}

    public Rectangle(string name, double width, double height) : base(name)
    {
        this.Width = width;
        this.Height = height;
    }

    public override double CalculateArea()
    {
        return this.Width * this.Height;
    }
}

class Triangle : Shape
{
    double Base {get; set;}
    double Height {get; set;}

    public Triangle(string name, double t_base, double height) : base(name)
    {
        this.Base = t_base;
        this.Height = height;
    }

    public override double CalculateArea() 
    {
        return 0.5 * this.Base * this.Height;
    }
}