Circle myCircle = new Circle("Круг", "Красный", "Сферическая");
Console.WriteLine(myCircle.GetName());
myCircle.Draw("Сплошная");
myCircle.PaperType = "Миллиметровка";
Rectangle myRectangle = new Rectangle("Синий", "Угловатая");
myRectangle.Draw("Пунктир");
myCircle.CalculateArea();
myRectangle.CalculateArea();

abstract class Shape
{
    protected string Color;
    protected string FormType;
    string LineStyle;

    public Shape(string color, string formType)
    {
        Color = color;
        FormType = formType;
    }

    public virtual void Draw(string lineStyle)
    {
        LineStyle = lineStyle;
        Console.WriteLine(LineStyle);
    }

    public abstract void CalculateArea();
}

class Circle : Shape
{
    private string Name;
    public string PaperType;

    public Circle(string name, string color, string formType)
        : base(color, formType)
    {
        Name = name;
        FormType = formType;
        Color = color;
    }

    public string GetName()
    { return Name; }

    public void Draw(string lineStyle)
    {
        Console.WriteLine($"{GetName()}: {lineStyle}");
    }

    public override void CalculateArea()
    {
        Console.WriteLine($"{GetName()} считает площадь на листе: {PaperType}");
    }
}

class Rectangle : Shape
{
    public Rectangle(string color, string formType) : base(color, formType)
    {

    }

    public override void CalculateArea()
    {
        Console.WriteLine($"Считает площадь по формуле сторон");
    }
}
