﻿// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
System.Console.Write ("Введите трехзначное число:");
int number = Convert.ToInt32 (Console.ReadLine ());

if (number > 999 || number < 100)
{
   System.Console.WriteLine ("Вы ввели не трехзначное число"); 
}
else{
    System.Console.WriteLine (number/10%10);
}