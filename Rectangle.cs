public class Rectangle : Shape
{
    double w;
    double h;
    public Rectangle(){}
    public Rectangle(double w, double h)
    {
        this.w=w;
        this.h=h;
    }
    public override double CalculateArea()
    {
       return w*h;
    }
}