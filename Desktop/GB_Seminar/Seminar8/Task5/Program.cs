// Заполните спирально массив 4 на 4.

Console.Clear();
int k = 4;
int[,] SpiralMatrix = new int[k, k];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= SpiralMatrix.GetLength(0) * SpiralMatrix.GetLength(1))
{
  SpiralMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < SpiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= SpiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > SpiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(SpiralMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}