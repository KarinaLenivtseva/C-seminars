// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckTheDay (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7){
        Console.WriteLine("УРА, ВЫХОДНОЙ!");
    }
else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Что еще за шуточки! Соберись и введи нормальное число");
    }
else Console.WriteLine("Этот день является рабочим. Трудимся!");
}
CheckTheDay(dayNumber);
