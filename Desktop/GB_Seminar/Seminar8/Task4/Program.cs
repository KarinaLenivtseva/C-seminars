// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

Console.Clear();
Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] FullArray = new int[x, y, z];
CreateArray(FullArray);
WriteArray(FullArray);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] FullArray)
{
  for (int i = 0; i < FullArray.GetLength(0); i++)
  {
    for (int j = 0; j < FullArray.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < FullArray.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={FullArray[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] FullArray)
{
  int[] temp = new int[FullArray.GetLength(0) * FullArray.GetLength(1) * FullArray.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < FullArray.GetLength(0); x++)
  {
    for (int y = 0; y < FullArray.GetLength(1); y++)
    {
      for (int z = 0; z < FullArray.GetLength(2); z++)
      {
        FullArray[x, y, z] = temp[count];
        count++;
      }
    }
  }
}