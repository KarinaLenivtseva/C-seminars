// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Enter number: ");
int EnteredNumber = Convert.ToInt32(Console.ReadLine());

int ResultOfSum(int EnteredNumber){
    int Counter = Convert.ToString(EnteredNumber).Length;
    int research = 0;
    int result = 0;
    for (int i = 0; i < Counter; i++){
        research = EnteredNumber - EnteredNumber % 10;
        result = result + (EnteredNumber - research);
        EnteredNumber = EnteredNumber / 10;
    }
    return result;
}

int FinalResult = ResultOfSum(EnteredNumber);
Console.WriteLine("Sum of numerals is: " + FinalResult);