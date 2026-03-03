namespace Taller02;

public class Factores
{
    // Private field that stores the number to decompose
    private int _number;

    // Private field that stores the list of factors
    private List<int> _factors;

    // Property with get and set for the number
    public int Number
    {
        get { return _number; }
        set { _number = value; }
    }

    // Property with get for the factors list
    public List<int> Factors
    {
        get { return _factors; }
        set { _factors = value; }
    }

    // Constructor that receives the number and computes its factors
    public Factores(int number)
    {
        ValidateNumber(number);
        _number = number;
        _factors = new List<int>();
        Decompose();
    }

    // Validates that the number is greater than 1, throws exception otherwise
    private static void ValidateNumber(int number)
    {
        if (number <= 1)
            throw new ArgumentException($"El numero: {number}, no es valido. Debe ser mayor que 1.");
    }

    // Decomposes the number into its prime factors
    private void Decompose()
    {
        int n = _number;
        int divisor = 2;
        while (n > 1)
        {
            if (n % divisor == 0)
            {
                _factors.Add(divisor);
                n /= divisor;
            }
            else
            {
                divisor++;
            }
        }
    }

    // Prints the factorization expression
    public void PrintExpression()
    {
        Console.WriteLine($"{_number} = {string.Join(" x ", _factors)}");
    }

    // Prints the step-by-step decomposition table
    public void PrintDecomposition()
    {
        Console.WriteLine("Descomposición:");
        int n = _number;
        foreach (int factor in _factors)
        {
            Console.WriteLine($"{n,5} | {factor}");
            n /= factor;
        }
        Console.WriteLine($"{n,5}");
    }
}
