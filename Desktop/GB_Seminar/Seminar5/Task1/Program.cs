// //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] number = new int[10];

void Body(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void Component(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int PositiveResult(int[] array){
    int amount = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      amount++;
    }
  }
  return amount;
}

Body(number, 100, 1000);
Component(number);
Console.WriteLine();

int amount = PositiveResult(number);
Console.WriteLine($"Quantity of positive numbers in mass is: {amount}");