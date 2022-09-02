void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}
}
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }
}
}
int[,] matrix = new int[3, 4];

int[,] GetSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
      for (int j = 0; j < matrix.GetLength(1) - 1 - k; j++)
      {
        if (matrix[i,j]>matrix[i,j+1])
        {
            int temp = matrix[i,j];
            matrix[i,j] = matrix[i,j+1];
            matrix[i,j+1]=temp;
        }
      }
      
    }
}
return matrix;
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
GetSort(matrix);
PrintArray(matrix);

