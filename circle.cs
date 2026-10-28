public class Circle : Shape
{
    double P;
    public Circle(){}
    public Circle(double s)
    {
        P=s;
    }
    public override double CalculateArea()
    {
     return P*P*3.14;   
    }
}