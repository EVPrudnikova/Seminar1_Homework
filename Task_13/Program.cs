int number = RandomInt(10, 1000); 
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);

int RandomInt(int arg1, int arg2)
{
    return new Random().Next(arg1, arg2);
}

if ((number/10 > 0) && (number/100 == 0))
{
    Console.WriteLine("Третьей цифры нет");
}

Console.WriteLine("Третья цифра: " + $"{stringNumber[2]}");
