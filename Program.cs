using Lab1;
using Lab1.quadratic_equation_data_getters;


IQuadraticEquationDataGetter quadraticEquationDataGetter;

if (args.Length > 0) quadraticEquationDataGetter = new QuadraticEquationDataGetterFromFile();
else quadraticEquationDataGetter = new QuadraticEquationDataGetterFromConsole();

QuadraticEquation quadraticEquation =  quadraticEquationDataGetter.getData();
QuadraticEquationResult res = quadraticEquationSolver.Solve(quadraticEquation);
res.printResult();