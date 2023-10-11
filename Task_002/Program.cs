// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326791123 -> 6

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
var x = number.ToString();

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(x[2]);
}


