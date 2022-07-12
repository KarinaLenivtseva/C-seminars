// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Please set the amount of elements of mass: ");
int amount = Convert.ToInt32(Console.ReadLine()); 

int numbers(int amount, int min, int max)
  {
  int[] randomNumbers = new int[amount];
  int Odds = 0;
  Console.Write("Mass: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);
      Console.Write(randomNumbers[i] + " ");
      if (i % 2 != 1)
      {
        Odds = Odds + randomNumbers[i];
      }
    }
  return Odds;
  }

int randomNumbers =  numbers(amount, 1, 10);

Console.WriteLine($"\n The sum of the elements on the odd positions: {randomNumbers}");