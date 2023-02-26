using System.Globalization;

namespace Lab1.quadratic_equation_data_getters;

public class QuadraticEquationDataGetterFromConsole: IQuadraticEquationDataGetter
{
    public QuadraticEquation getData()
    {
        float a, b, c;
        Console.Write("A: "); 
        a = float.Parse(Console.ReadLine());
        Console.Write("B: ");
        b = float.Parse(Console.ReadLine());
        Console.Write("C: ");
        c = float.Parse(Console.ReadLine());        
        
        return new QuadraticEquation(a,b,c);
    }
}