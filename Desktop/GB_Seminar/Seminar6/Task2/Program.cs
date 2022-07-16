// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
Console.WriteLine($"\nЭта программа найдет для Вас точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. Значения b1, k1, b2 и k2 Вам необходимо будет задать самостоятельно. Приступим!");
double[,] coefficients = new double[2, 2];
double[] CrossPoint = new double[2];

void InputCoefficients(){
  for (int i = 0; i < coefficients.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coefficients.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coefficients[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Result(double[,] coeff)
{
  CrossPoint[0] = (coefficients[1,1] - coefficients[0,1]) / (coefficients[0,0] - coefficients[1,0]);
  CrossPoint[1] = CrossPoint[0] * coefficients[0,0] + coefficients[0,1];
  return CrossPoint;
}

void Response(double[,] coefficients)
{
  if (coefficients[0,0] == coefficients[1,0] && coefficients[0,1] == coefficients[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coefficients[0,0] == coefficients[1,0] && coefficients[0,1] != coefficients[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Result(coefficients);
    Console.Write($"\nТочка пересечения прямых: ({CrossPoint[0]}, {CrossPoint[1]})");
  }
}

InputCoefficients();
Response(coefficients);