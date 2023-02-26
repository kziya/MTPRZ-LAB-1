namespace Lab1.quadratic_equation_data_getters;

public class QuadraticEquationDataGetterFromConsole: IQuadraticEquationDataGetter
{
    public QuadraticEquation getData()
    {
        return new QuadraticEquation(1,1,1);
    }
}