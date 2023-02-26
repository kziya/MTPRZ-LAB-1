namespace Lab1;

public class QuadraticEquationSolver
{
   public QuadraticEquationResult Solve(QuadraticEquation quadraticEquation)
   {
      float a = quadraticEquation.a, b = quadraticEquation.b, c = quadraticEquation.c;
      float d = b * b - (4 * a * c);

      if (d < 0) return new QuadraticEquationResult("No result !");
      double x1 = (-b + Math.Pow(d, 0.5)) / (2 * a);
      double x2 = (-b - Math.Pow(d, 0.5)) / (2 * a);
      return new QuadraticEquationResult((float)x1, (float)x2);
   }
}