//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

int DayNumber = check(number);

int check (int number)
{
        if (number == 6|| number ==7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
    return number;
}
