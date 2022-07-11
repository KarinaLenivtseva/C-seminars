//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] CreateRandomArray()
{
    int[] RandomArray = new int[8];
    for (int i = 0; i < 8; i++)
{
    RandomArray[i] = new Random().Next(0, 10);
    Console.Write(RandomArray[i] + " ");
}
return RandomArray;
}
int[] myArray = CreateRandomArray();