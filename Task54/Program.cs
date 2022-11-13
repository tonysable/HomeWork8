int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}

void SortMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int b = 0; b < matrix.GetLength(1); b++)
        {
            for(int j = 1; j < matrix.GetLength(1); j++)
            {

                if(matrix[i, j] > matrix[i, j - 1])
                {
                    int temp = matrix[i, j - 1];
                    matrix[i, j - 1] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }
}
int rows = 3;
int columns = 4;
int[,] table = CreateMatrix(rows, columns, 1, 15);
PrintMatrix(table);
SortMatrix(table);
Console.WriteLine();
PrintMatrix(table);

