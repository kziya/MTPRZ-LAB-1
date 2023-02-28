using Lab1;
using Lab1.quadratic_equation_data_getters;


QuadraticEquationSolver quadraticEquationSolver = new QuadraticEquationSolver();
IQuadraticEquationDataGetter quadraticEquationDataGetter;

if (args.Length > 0) quadraticEquationDataGetter = new QuadraticEquationDataGetterFromFile();
else quadraticEquationDataGetter = new QuadraticEquationDataGetterFromConsole();

QuadraticEquation quadraticEquation =  quadraticEquationDataGetter.getData(args.Length > 0 ? args[0] : null);
QuadraticEquationResult res = quadraticEquationSolver.Solve(quadraticEquation);
res.printResult();