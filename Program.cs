using Lab1;
using Lab1.quadratic_equation_data_getters;

if (args.Length > 0)
{
    QuadraticEquationSolver quadraticEquationSolver =
        new QuadraticEquationSolver(new QuadraticEquationDataGetterFromFile());
}
else
{
    QuadraticEquationSolver quadraticEquationSolver =
        new QuadraticEquationSolver(new QuadraticEquationDataGetterFromFile());
    quadraticEquationSolver.Solve();
}