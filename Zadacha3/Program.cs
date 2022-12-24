// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7)
{
    Console.WriteLine("Ошибка");
}
else if (number >= 6)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}