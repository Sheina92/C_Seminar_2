﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Write("Введите цифру, обозначающую день недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 5)
{
    Console.WriteLine("Нет");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Цифра не соответствует дню недели");
}

