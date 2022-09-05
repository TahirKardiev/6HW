void PrintArray(int[,] matrix1)
{
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        Console.Write($"{matrix1[i, j]} ");
    }
Console.WriteLine();
}
}
void FillArray(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i,j] = new Random().Next(1,10);
    }
}
}
int[,] matrix1 = new int[5, 4];

void FillArray1(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i,j] = new Random().Next(1,10);
    }
}
}
int[,] matrix2 = new int[5, 4];

int[,] resultMatrix = new int[5,4];
void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray1(matrix2);
PrintArray(matrix2);
MultiplyMatrix(matrix2,matrix1,resultMatrix);
Console.WriteLine();
PrintArray(resultMatrix);


