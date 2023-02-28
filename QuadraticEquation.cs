namespace Lab1;

public class QuadraticEquation
{
    public float a, b, c;

    public QuadraticEquation(float a, float b, float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public void printEquation()
    {
        Console.WriteLine($"({this.a}) x^2 + ({ this.b })x + ({this.c}) = 0");
    }
}