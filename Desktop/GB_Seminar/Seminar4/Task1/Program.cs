﻿//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Grade(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
}

  Console.Write("Enter number A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter number B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int degree = Grade(numberA, numberB);
  Console.WriteLine("Answer: " + degree);