int[,,] CreateMatrix3(int rows, int columns, int depth, int min, int max)
{
    var matrix = new int[rows, columns, depth];
    var rnd = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
            
        }
    }
    return matrix;
}

void PrintMatrix3(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            
        }
        Console.WriteLine();
    }
}

int[,,] Matrix3D = CreateMatrix3(2, 2, 2, 10, 98);
PrintMatrix3(Matrix3D);
