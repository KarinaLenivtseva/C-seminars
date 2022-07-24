// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите количество строк 1ой матрицы: ");
int n = InputNumbers("Введите количество столбцов 1ой матрицы (это будет и количество строк 2ой матрицы): ");
int p = InputNumbers("Введите количество столбцов 2ой матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] FirstMartrix = new int[m, n];
CreateArray(FirstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(FirstMartrix);

int[,] SecondMartrix = new int[n, p];
CreateArray(SecondMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(SecondMartrix);

int[,] ResultMatrix = new int[m,p];

MegaMatrix(FirstMartrix, SecondMartrix, ResultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(ResultMatrix);

void MegaMatrix(int[,] FirstMartrix, int[,] SecondMartrix, int[,] ResultMatrix)
{
  for (int i = 0; i < ResultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < ResultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < FirstMartrix.GetLength(1); k++)
      {
        sum += FirstMartrix[i,k] * SecondMartrix[k,j];
      }
      ResultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}