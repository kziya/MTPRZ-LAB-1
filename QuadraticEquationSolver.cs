using Lab1.quadratic_equation_data_getters;

namespace Lab1;

public class QuadraticEquationSolver
{
   private IQuadraticEquationDataGetter quadraticDataGetter;

   public QuadraticEquationSolver(IQuadraticEquationDataGetter dataGetter)
   {
      this.quadraticDataGetter = dataGetter;
   }
   
   public float Solve(float a, float b, float c)
   {
      QuadraticEquation quadraticEquation = this.quadraticDataGetter.getData();
      return 0;
   }
}