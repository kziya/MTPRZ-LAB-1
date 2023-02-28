using System.Globalization;

namespace Lab1.quadratic_equation_data_getters;

public class QuadraticEquationDataGetterFromConsole: IQuadraticEquationDataGetter
{
    public QuadraticEquation getData(string filePath = "")
    {
        bool isA = false, isB = false, isC = false;
        float a = 0, b = 0, c = 0;
        
        while (isA == false || a == 0 || float.IsNaN(a))
        {
            Console.Write("A: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            float.TryParse(Console.ReadLine(), out a);
            isA = true;
            Console.ResetColor();
        }
        
        while (isB == false ||  float.IsNaN(b))
        {
            Console.Write("B: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            float.TryParse(Console.ReadLine(), out b);
            isB = true;
            Console.ResetColor();
        }

        while (isC == false || float.IsNaN(c))
        {
            Console.Write("C: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            float.TryParse(Console.ReadLine(),out  c);
            isC = true;
            Console.ResetColor();
        }
        
        return new QuadraticEquation(a,b,c);
    }
}