using System.Security.Cryptography.X509Certificates;

namespace Lab1;

public class QuadraticEquationResult
{
    private float x1, x2;
    private string message = null;
    
    public QuadraticEquationResult(float x1, float x2)
    {
        this.x1 = x1;
        this.x2 = x2;
    }
    
    public QuadraticEquationResult(string message)
    {
        this.message = message;
    }

    public void printResult()
    {
        if(this.message != null) Console.WriteLine(this.message);
        else Console.WriteLine($"X1: {x1.ToString()}\nX2: {x2.ToString()}");
    }
}