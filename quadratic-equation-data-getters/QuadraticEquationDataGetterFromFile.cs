using System.Text.RegularExpressions;

namespace Lab1.quadratic_equation_data_getters;

public class QuadraticEquationDataGetterFromFile: IQuadraticEquationDataGetter
{
    public QuadraticEquation getData(string filePath)
    {
        bool isExists = File.Exists(filePath);
        if (!isExists)
        {
            Console.WriteLine($"File {filePath} does not exist !");
            return null;
        }

        

        string[] fileData = Regex.Replace(File.ReadAllText(filePath), @"\s+"," ").Trim().Split(' ');
        if (fileData.Length != 3)
        {
            Console.WriteLine("File format is invalid !");
        }
        float a, b, c;
        float.TryParse(fileData[0], out a);
        float.TryParse(fileData[1], out b);
        float.TryParse(fileData[2], out c);

        if (float.IsNaN(a) || float.IsNaN(b) || float.IsNaN(c))
        {
            Console.WriteLine("File format is invalid !");
            return null;
        }
        
        
        return new QuadraticEquation(a,b,c);
    }
}