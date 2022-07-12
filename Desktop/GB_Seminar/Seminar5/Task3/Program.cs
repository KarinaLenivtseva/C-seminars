// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] RealNumbers = new double[10];
  for (int i = 0; i < RealNumbers.Length; i++ )
  {
    RealNumbers[i] = new Random().Next(-100, 100);
    Console.Write(RealNumbers[i] + " ");
  }
double MaxNum = RealNumbers[0];
double MinNum = RealNumbers[0];
  for (int i = 1; i < RealNumbers.Length; i++)
  {
    if (MaxNum < RealNumbers[i])
    {
      MaxNum = RealNumbers[i];
    }
        if (MinNum > RealNumbers[i])
    {
      MinNum = RealNumbers[i];
    }
  }
  double result = MaxNum - MinNum;
  Console.WriteLine($"\n The difference between max {MaxNum} and min {MinNum} elements is {result}");