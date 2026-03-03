using Taller02;
// Héctor Javier Mantilla
//Square Matrix
try
{
    Console.Write("Ingrese orden de la matriz: ");
    int order = int.Parse(Console.ReadLine()!);

    MatrizCuadrada matriz = new MatrizCuadrada(order);
    matriz.PrintMatrix();
    Console.WriteLine($"La sumatoria es: {matriz.Sum()}");
    Console.WriteLine($"El valor máximo es: {matriz.Max()}");
    Console.WriteLine($"El valor mínimo es: {matriz.Min()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine();

//Factor Decomposition
try
{
    Console.Write("Ingrese el número a descomponer: ");
    int number = int.Parse(Console.ReadLine()!);

    Factores factores = new Factores(number);
    factores.PrintExpression();
    factores.PrintDecomposition();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
