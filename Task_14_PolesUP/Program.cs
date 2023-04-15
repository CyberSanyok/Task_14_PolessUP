internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = { { 1, -1, 1 }, 
                          { -1, 1, 1 },
                          { 1, 1, -1 } };
        Conclusion(matrix);
        int[,] matrix2 = { { 1, -2, 3},
                           { -4, -5, 6} };
        Conclusion(matrix2);

    }
    public static void Conclusion(int[,] matrix)
    {
        if (NumOfNegative(matrix) % 2 == 0) Console.WriteLine("Максимальная сумма: " + MatrixSum(matrix));
        else
        {
            Console.WriteLine("Максимальная сумма: " + MatrixSumIfOddOfNegativeNum(matrix));
        }
    }
    public static int NumOfNegative(int[,] matrix)
    {
        int negitive = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0) negitive++;
            }
        }
        return negitive;
    }
   public static int MatrixSum(int[,] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) ; j++)
            {
                if (matrix[i, j] < 0)
                    sum += (-1) * matrix[i, j];
                else sum += matrix[i, j];
            }
        }
        return sum;
    }
    public static int MatrixSumIfOddOfNegativeNum(int[,]matrix) 
    {
        int max = -2147483647;
        int[] maxIndex = {0,0 };
        for (int i = 0; i <matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0 && matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    maxIndex[0] = i; maxIndex[1] = j;
                }
            }
        }
        return MatrixSum(matrix)+max*2;
    }
    
}