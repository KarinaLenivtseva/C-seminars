// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите координаты позиции элемента. Рекомендуем разделить позиции запятой  ");

string? PositionOfElement = Console.ReadLine();
PositionOfElement = Choice(PositionOfElement);
int[] position = Parser(PositionOfElement);

if (position[0] <= m && position[1] <= n && position[0] >= 0 && position[1] >= 0)
{
    double result = array[position[0] - 1, position[1] - 1];
    Console.Write($"Так это ж элемент {result}!");
}
else Console.Write($"В массиве нет подобного элемента.");

int[] Parser(string input)
{
    int counter = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
            counter++;
    }

    int[] numbers = new int[counter];

    int NumberIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string substring = String.Empty;

        while (input[i] != ',')
        {
            substring += input[i].ToString();
            if (i >= input.Length - 1)
                break;
            i++;
        }
        numbers[NumberIndex] = Convert.ToInt32(substring);
        NumberIndex++;
    }

    return numbers;
}
string Choice (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}