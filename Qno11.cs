using System;

class MatrixMultiplication
{
    /*static void Main()
    {
        // Initialize matrices
        int[,] matrixA = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[,] matrixB = {
            { 7, 8 },
            { 9, 10 },
            { 11, 12 }
        };

        // Perform matrix multiplication
        int[,] result = MultiplyMatrices(matrixA, matrixB);

        // Print the result
        PrintMatrix(result);
        Console.ReadKey();
    }
    */
    static int[,] MultiplyMatrices(int[,] a, int[,] b)
    {
        int rowsA = a.GetLength(0);
        int colsA = a.GetLength(1);
        int colsB = b.GetLength(1);

        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsA; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
