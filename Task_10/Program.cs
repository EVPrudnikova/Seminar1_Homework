// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondNumber(number);
Console.Write("Второе чиcло: " + result);

int SecondNumber(int arg)
{
    int second = (arg % 100) / 10;
    return second;
}
