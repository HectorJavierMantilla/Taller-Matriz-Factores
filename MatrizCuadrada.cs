namespace Taller02;

public class MatrizCuadrada
{
    // Private field that stores the matrix
    private int[,] _matrix;

    // Private field that stores the order of the matrix
    private int _order;

    // Property with get and set for the order
    public int Order
    {
        get { return _order; }
        set { _order = value; }
    }

    // Property with get and set for the matrix
    public int[,] Matrix
    {
        get { return _matrix; }
        set { _matrix = value; }
    }

    // Constructor that receives the order and fills the matrix
    public MatrizCuadrada(int order)
    {
        ValidateOrder(order);
        _order = order;
        _matrix = new int[order, order];
        FillMatrix();
    }

    // Validates that the order is greater than 0, throws exception otherwise
    private static void ValidateOrder(int order)
    {
        if (order <= 0)
            throw new ArgumentException($"El orden: {order}, no es valido. Debe ser mayor que 0.");
    }

    // Fills each cell using the formula: Celda[i][j] = (i + 1) - j
    private void FillMatrix()
    {
        for (int i = 0; i < _order; i++)
            for (int j = 0; j < _order; j++)
                _matrix[i, j] = (i + 1) - j;
    }

    // Prints the matrix to the console
    public void PrintMatrix()
    {
        for (int i = 0; i < _order; i++)
        {
            for (int j = 0; j < _order; j++)
                Console.Write($"{_matrix[i, j],3}");
            Console.WriteLine();
        }
    }

    // Returns the sum of all elements in the matrix
    public int Sum()
    {
        int total = 0;
        for (int i = 0; i < _order; i++)
            for (int j = 0; j < _order; j++)
                total += _matrix[i, j];
        return total;
    }

    // Returns the maximum element in the matrix
    public int Max()
    {
        int max = _matrix[0, 0];
        for (int i = 0; i < _order; i++)
            for (int j = 0; j < _order; j++)
                if (_matrix[i, j] > max)
                    max = _matrix[i, j];
        return max;
    }

    // Returns the minimum element in the matrix
    public int Min()
    {
        int min = _matrix[0, 0];
        for (int i = 0; i < _order; i++)
            for (int j = 0; j < _order; j++)
                if (_matrix[i, j] < min)
                    min = _matrix[i, j];
        return min;
    }
}
