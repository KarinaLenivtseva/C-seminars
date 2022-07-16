// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

int[,] Array = new int[m, n];
Array = ChangedArray(array);

WriteArrayInt(Array);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
    double Average = 0;
    for (int j = 0; j < m; j++)
    {
        Average += Array[j, i];
    }
    Average = Math.Round(Average / m, 1);
    Console.WriteLine($"столбца № {i + 1} {Average}");
}

int[,] ChangedArray(double[,] array)
{
    int[,] Array = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Array[i, j] = Convert.ToInt32(array[i, j]);
        }
    }
    return Array;
}

void WriteArrayInt(int[,] FullArray)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(FullArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}