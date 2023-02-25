namespace Lab1;

public class QuadraticEquationSolver
{
   public QuadraticEquationResult Solve(QuadraticEquation quadraticEquation)
   {
      float a = quadraticEquation.a, b = quadraticEquation.b, c = quadraticEquation.c;
      float d = b * b - (4 * a * c);
      if (d < 0)
      {
         return new QuadraticEquationResult("No result 1");
      }
      else
      {
         
      }

      return new QuadraticEquationResult(1, 2);
   }
}