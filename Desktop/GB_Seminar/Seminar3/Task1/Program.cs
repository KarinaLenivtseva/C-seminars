// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

void CheckNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine("Ваше число - палиндром.");
  }
  else Console.WriteLine("Ваше число - не палиндром. Сочувствую!");
}

if (number!.Length == 5)
{
  CheckNumber(number);
}
else Console.WriteLine("Пожалуйста, введите правильное число");