// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int a = number % 100;
int b = a / 10;

if (number > 999)
{
    Console.WriteLine("Ошибка");
}
else if (number < 100)
{
     Console.WriteLine("Ошибка");
}
else
{
    Console.WriteLine(b);
}