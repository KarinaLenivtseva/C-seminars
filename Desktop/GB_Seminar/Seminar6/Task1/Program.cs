// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine ("Введите желаемое количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[m];

void Numbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massive[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int match(int[] massive)
{
  int count = 0;
  for (int i = 0; i < massive.Length; i++)
  {
    if(massive[i] > 0 ) count += 1; 
  }
  return count;
}

Numbers(m);

Console.WriteLine($"Чисел больше 0 было введено {match(massive)}");