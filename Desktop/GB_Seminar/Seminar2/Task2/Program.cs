// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberInfo = Convert.ToString(number);
if (numberInfo.Length > 2) 
{
Console.WriteLine("Третья цифра - " + numberInfo[2]);
}

else 
{
    Console.WriteLine("Прекратите баловаться");
}